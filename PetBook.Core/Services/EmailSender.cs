using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;



namespace PetBook.Core.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration configuration;
        public EmailSender(IConfiguration _config)
        {
            configuration = _config;
        }
       

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var sendgridApiKey = configuration.GetSection("SENDGRID:SENDGRID_API_KEY").Value;
            if (string.IsNullOrEmpty(sendgridApiKey))
            {
                throw new Exception("Null SendGridKey");
            }
            var path = configuration.GetSection("EmailTemplateDirectory").Value;
            var template = await File.ReadAllTextAsync(Path.GetFullPath(path));

            template = template.Replace("{ReplaceWithToken}", htmlMessage);
            template = template.Replace("{ReplaceWithAction}", subject);
            await Execute(sendgridApiKey, subject, template, email);
        }

        public async Task Execute(string apiKey, string subject, string message, string toEmail)
        {
            var from = configuration.GetSection("SENDGRID:SENDGRID_EMAIL").Value;
            var client = new SendGridClient(apiKey);
           
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(from, subject),
                Subject = subject,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(toEmail));

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);
            var response = await client.SendEmailAsync(msg);
            Console.WriteLine(response.StatusCode);
           
        }
    }
}
