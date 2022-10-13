using aquasend.Models;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Services
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _configuration;
        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendMailAsync(User user, string toEmail, string subject, string content, bool sendAsync = true)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress(_configuration["AppSettings:AppName"], "onyekwerekelechimac@gmail.com");
            MailboxAddress to = new MailboxAddress(user.FirstName, user.Email);

            message.From.Add(from);
            message.To.Add(to);
            message.Subject = "Hi " + user.FirstName + " , " + subject;

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = content;
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                //client.Connect("smtp.mail.yahoo.com", 465, true);
                //client.Authenticate("email@gmail.com", "key"); // If using GMail this requires turning on LessSecureApps : https://myaccount.google.com/lesssecureapps
                client.Connect("in-v3.mailjet.com", 465, true);
                client.Authenticate(_configuration["AppSettings:MailJetAPIKey"], _configuration["AppSettings:MailJetSecKey"]);
                if (sendAsync)
                {
                    await client.SendAsync(message);
                }
                else
                {
                    client.Send(message);
                }
                client.Disconnect(true);
            }
        }
    }
}
