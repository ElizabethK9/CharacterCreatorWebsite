using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

public class SendGridServiceClass
{
    private readonly string _apiKey;
    private readonly string _baseUrl;

    public SendGridServiceClass(string apiKey, string baseUrl)
    {
        _apiKey = apiKey;
        _baseUrl = baseUrl;
    }

    // Method to send a generic email
    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var client = new SendGridClient(_apiKey);
        var from = new EmailAddress("noreply@yourdomain.com", "Your App Name");
        var to = new EmailAddress(toEmail);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, body, body);
        var response = await client.SendEmailAsync(msg);

        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"Email failed: {response.StatusCode}");
        }
    }

    // Method to generate a confirmation link
    public string GenerateConfirmationLink(string email, string token)
    {
        return $"{_baseUrl}/Account/ConfirmEmail?email={Uri.EscapeDataString(email)}&token={Uri.EscapeDataString(token)}";
    }

    // Method to send a confirmation email
    public async Task SendConfirmationEmailAsync(string toEmail, string username, string confirmationLink)
    {
        string subject = "Confirm Your Account";
        string body = $@"
            Hi {username},
            <br><br>
            Thank you for signing up! Please confirm your account by clicking the link below:
            <br><br>
            <a href='{confirmationLink}'>Confirm Account</a>
            <br><br>
            If you did not create this account, please ignore this email.
            <br><br>
            Regards, <br> Your App Name";

        await SendEmailAsync(toEmail, subject, body);
    }
}
