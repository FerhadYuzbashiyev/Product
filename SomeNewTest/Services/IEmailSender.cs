using System.Threading.Tasks;

namespace SomeNewTest.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
