using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CharacterCreatorWebsite.Data;
using CharacterCreatorWebsite.Models;
using CharacterCreatorWebsite.ViewModels;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using BCrypt.Net;


namespace CharacterCreatorWebsite.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SendGridServiceClass _sendGridService;

        public ProfileController(ApplicationDbContext context, SendGridServiceClass sendGridService)
        {
            _context = context;
            _sendGridService = sendGridService;
        }

        // Profile Page (GET)
        [HttpGet]
        public IActionResult Profile()
        {
            var username = User.Identity?.Name; // Safely get the logged-in user's username
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login"); // Redirect if username is null
            }

            var user = _context.Profiles.Include(p => p.Characters)
                                        .FirstOrDefault(p => p.Username == username);

            if (user == null)
            {
                return RedirectToAction("Login"); // Redirect if user not found
            }

            var mostRecentCharacter = user.Characters?
                                      .OrderByDescending(c => c.CreatedOn)
                                      .FirstOrDefault();

            var model = new ProfileViewModel
            {
                Username = user.Username,
                MostRecentCharacter = mostRecentCharacter
            };

            return View(model);
        }

        // All Characters Page (GET)
        [HttpGet]
        public IActionResult AllCharacters()
        {
            var username = User.Identity?.Name;
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login");
            }

            var user = _context.Profiles.Include(p => p.Characters)
                                        .FirstOrDefault(p => p.Username == username);

            if (user == null)
            {
                return RedirectToAction("Login");
            }

            var model = new ProfileViewModel
            {
                Username = user.Username,
                AllCharacters = user.Characters.ToList()
            };

            return View(model);
        }

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
                // Check for existing user/email
                var existingUser = _context.Profiles.FirstOrDefault(p => p.Email == email);
                if (existingUser != null)
                {
                    ViewBag.Error = "An account with this email already exists.";
                    return View();
                }

                var existingUsername = _context.Profiles.FirstOrDefault(p => p.Username == username);
                if (existingUsername != null)
                {
                    ViewBag.Error = "This username is already taken.";
                    return View();
                }

                // Hash the password for security
                var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // Generate confirmation token
                var token = Guid.NewGuid().ToString();

                var newUser = new ProfileClass
                {
                    Email = email,
                    Username = username,
                    Password = hashedPassword,
                    ConfirmationToken = token,
                    IsEmailConfirmed = false
                };

                _context.Profiles.Add(newUser);
                await _context.SaveChangesAsync();

                // Generate and send confirmation email
                var confirmationLink = _sendGridService.GenerateConfirmationLink(email, token);
                await _sendGridService.SendConfirmationEmailAsync(email, username, confirmationLink);

                return RedirectToAction("Login");
            }

            ViewBag.Error = "All fields are required.";
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }
            // Login (POST)
            [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = _context.Profiles.FirstOrDefault(p => p.Username == username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                ViewBag.Error = "Invalid username or password.";
                return View();
            }

            if (!user.IsEmailConfirmed)
            {
                ViewBag.Error = "Please confirm your email before logging in.";
                return View();
            }

            // Create authentication claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("Profile");
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

            // Hash the new password
            user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
            user.ConfirmationToken = null; // Clear the token
            await _context.SaveChangesAsync();

            ViewBag.Message = "Your password has been reset successfully.";
            return RedirectToAction("Login");
        }
    }
}
