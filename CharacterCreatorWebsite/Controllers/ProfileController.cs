using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CharacterCreatorWebsite.Data;
using CharacterCreatorWebsite.Models;
using CharacterCreatorWebsite.ViewModels;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace CharacterCreatorWebsite.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SendGridServiceClass _sendGridService;

        public ProfileController(ApplicationDbContext context, SendGridServiceClass sendGridService)
        {
            _context = context; // Inject the database context
            _sendGridService = sendGridService; // Inject the SendGrid service
        }

        // Index Action (optional)
        public IActionResult Index()
        {
            return View("Profile");
        }

        // Profile Page (GET)
        [HttpGet]
        public IActionResult Profile()
        {
            var username = User.Identity.Name; // Get the logged-in user's username
            var user = _context.Profiles.Include(p => p.Characters) // Include related Characters
                                        .FirstOrDefault(p => p.Username == username);

            if (user == null)
            {
                return RedirectToAction("Login"); // Redirect to login if the user is not found
            }

            // Get the most recently saved character
            var mostRecentCharacter = user.Characters
                                          .OrderByDescending(c => c.CreatedOn) // Sort by creation date
                                          .FirstOrDefault();

            // Pass the data to the view using a ViewModel
            var model = new ProfileViewModel
            {
                Username = user.Username,
                MostRecentCharacter = mostRecentCharacter
            };

            return View(model); // Render the Profile view
        }

        // All Characters Page (GET)
        [HttpGet]
        public IActionResult AllCharacters()
        {
            var username = User.Identity.Name; // Get the logged-in user's username
            var user = _context.Profiles.Include(p => p.Characters) // Include related Characters
                                        .FirstOrDefault(p => p.Username == username);

            if (user == null)
            {
                return RedirectToAction("Login"); // Redirect to login if the user is not found
            }

            // Pass all characters to the view
            return View(user.Characters);
        }

        // Register (GET)
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Register (POST)
        [HttpPost]
        public async Task<IActionResult> Register(string email, string username, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Check if the email already exists
                var existingUser = _context.Profiles.FirstOrDefault(p => p.Email == email);
                if (existingUser != null)
                {
                    ViewBag.Error = "An account with this email already exists.";
                    return View();
                }

                // Check if the username already exists
                var existingUsername = _context.Profiles.FirstOrDefault(p => p.Username == username);
                if (existingUsername != null)
                {
                    ViewBag.Error = "This username is already taken.";
                    return View();
                }

                // Generate a confirmation token
                var token = Guid.NewGuid().ToString();

                // Create and save the new user
                var newUser = new ProfileClass
                {
                    Email = email,
                    Username = username,
                    Password = password,
                    ConfirmationToken = token,
                    IsEmailConfirmed = false // Not confirmed yet
                };

                _context.Profiles.Add(newUser);
                await _context.SaveChangesAsync();

                // Generate confirmation link
                var confirmationLink = _sendGridService.GenerateConfirmationLink(email, token);

                // Send confirmation email
                await _sendGridService.SendConfirmationEmailAsync(email, username, confirmationLink);

                return RedirectToAction("Login");
            }

            ViewBag.Error = "All fields are required.";
            return View();
        }

        // Confirm Email (GET)
        [HttpGet]
        public IActionResult ConfirmEmail(string email, string token)
        {
            var user = _context.Profiles.FirstOrDefault(p => p.Email == email && p.ConfirmationToken == token);

            if (user != null)
            {
                user.IsEmailConfirmed = true; // Confirm email
                user.ConfirmationToken = null; // Clear token
                _context.SaveChanges();
                ViewBag.Message = "Your email has been successfully confirmed!";
            }
            else
            {
                ViewBag.Message = "Invalid confirmation link.";
            }

            return View();
        }

        // Login (GET)
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Login (POST)
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Profiles.FirstOrDefault(p => p.Username == username && p.Password == password);

            if (user != null)
            {
                if (!user.IsEmailConfirmed)
                {
                    ViewBag.Error = "Please confirm your email before logging in.";
                    return View();
                }

                // Redirect to Profile page upon successful login
                return RedirectToAction("Profile");
            }

            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        // Forgot Password (GET)
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // Forgot Password (POST)
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var user = _context.Profiles.FirstOrDefault(p => p.Email == email);
            if (user == null)
            {
                ViewBag.Error = "No account associated with this email.";
                return View();
            }

            // Generate a password reset token
            var token = Guid.NewGuid().ToString();
            user.ConfirmationToken = token; // Reuse the ConfirmationToken field for password reset
            await _context.SaveChangesAsync();

            // Generate reset link
            var resetLink = _sendGridService.GenerateConfirmationLink(email, token);

            // Send reset email
            string subject = "Reset Your Password";
            string body = $@"
                Hi {user.Username},
                <br><br>
                You can reset your password by clicking the link below:
                <br><br>
                <a href='{resetLink}'>Reset Password</a>
                <br><br>
                If you did not request a password reset, please ignore this email.
                <br><br>
                Regards, <br> Your App Name";
            await _sendGridService.SendEmailAsync(email, subject, body);

            ViewBag.Message = "A password reset link has been sent to your email.";
            return View();
        }

        // Reset Password (GET)
        [HttpGet]
        public IActionResult ResetPassword(string email, string token)
        {
            var user = _context.Profiles.FirstOrDefault(p => p.Email == email && p.ConfirmationToken == token);

            if (user == null)
            {
                ViewBag.Error = "Invalid or expired password reset link.";
                return View();
            }

            ViewBag.Email = email;
            ViewBag.Token = token;
            return View();
        }

        // Reset Password (POST)
        [HttpPost]
        public async Task<IActionResult> ResetPassword(string email, string token, string newPassword)
        {
            var user = _context.Profiles.FirstOrDefault(p => p.Email == email && p.ConfirmationToken == token);

            if (user == null)
            {
                ViewBag.Error = "Invalid or expired password reset link.";
                return View();
            }

            user.Password = newPassword; // Replace with hashed password in a production app
            user.ConfirmationToken = null; // Clear the token
            await _context.SaveChangesAsync();

            ViewBag.Message = "Your password has been reset successfully.";
            return RedirectToAction("Login");
        }
    }
}
