using System.Threading.Tasks;

namespace MST.IDP.Services.EmailService
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject, string message);
    }
}
