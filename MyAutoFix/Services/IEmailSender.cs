using MyAutoFix.Models;
using System.Threading.Tasks;

namespace MyAutoFix.Services
{
    public interface IEmailSender
    {
        Task SendAsyc(EmailMessage message);
    }
}
