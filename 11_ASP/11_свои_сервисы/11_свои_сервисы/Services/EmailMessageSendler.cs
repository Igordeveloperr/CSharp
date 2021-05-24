using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

namespace _11_свои_сервисы.Services
{
    public class EmailMessageSendler
    {
        public async Task Send()
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "g.bikmetow@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("Bobik", "g.bikmetow@gmail.com"));
            emailMessage.Subject = "SUUUUUUUUUUUUUUUUB";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = "Стоооп что это типа из asp мммм?"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 25, false);
                await client.AuthenticateAsync("g.bikmetow@gmail.com", "ujif1357924680");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
