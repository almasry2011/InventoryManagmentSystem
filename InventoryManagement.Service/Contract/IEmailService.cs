using InventoryManagement.Domain.Settings;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
