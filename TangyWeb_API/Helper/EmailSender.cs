using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace TangyWeb_API.Helper
{
    public class EmailSender : IEmailSender
    {
        public string SendGridSecret { get; set; }

        public EmailSender(IConfiguration _config)
        {
            SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {
                var client = new SendGridClient(SendGridSecret);
                var from = new EmailAddress("hello@dotnetmastery.com", "Tangy");
                var to = new EmailAddress(email);
                var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
                await client.SendEmailAsync(msg);
                //var emailToSend = new MimeMessage();
                //emailToSend.From.Add(MailboxAddress.Parse("hello@dotnetmastery.com"));
                //emailToSend.To.Add(MailboxAddress.Parse(email));
                //emailToSend.Subject = subject;
                //emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlMessage };

                ////send email
                //using var emailClient = new SmtpClient();
                //emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                //emailClient.Authenticate("dotnetmastery@gmail.com", "DotNet123$*");
                //emailClient.Send(emailToSend);
                //emailClient.Disconnect(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
