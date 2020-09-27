using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Service
{
    public static class EmailService
    {
        public static async Task SendEmailAsync(string name, string email, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Cactus Anonim", "cactusAnonim@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("Administration", Config.CompanyEmail));
            emailMessage.Subject = $"QUESTION FROM {name}";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = $@"{message}
                Contact Mail: {email}"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync("cactusAnonim@yandex.ru", "cactusAnonim123");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
