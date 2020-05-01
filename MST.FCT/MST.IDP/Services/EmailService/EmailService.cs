using MST.IDP.Configuration.Interfaces;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MST.IDP.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IRootConfiguration _rootConfiguration;

        public EmailService(IRootConfiguration rootConfiguration)
        {

            _rootConfiguration = rootConfiguration;
        }
        public async Task SendEmail(string email, string subject, string message)
        {
            using (var client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                var credential = new NetworkCredential
                {
                    UserName = _rootConfiguration.EmailConfiguration.Email,
                    Password = _rootConfiguration.EmailConfiguration.Password
                };

                client.Credentials = credential;
                client.Host = _rootConfiguration.EmailConfiguration.Host;
                client.Port = int.Parse(_rootConfiguration.EmailConfiguration.Port);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(email));
                    emailMessage.From = new MailAddress(_rootConfiguration.EmailConfiguration.Email);
                    emailMessage.Subject = subject;
                    emailMessage.Body = message;
                    client.Send(emailMessage);
                }
            }
            await Task.CompletedTask;
        }
    }
}
