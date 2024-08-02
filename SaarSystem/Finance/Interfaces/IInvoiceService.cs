using System.Collections.Generic;
using System.Threading.Tasks;
using SaarSystem.Finance.Models;

namespace SaarSystem.Finance.Interfaces
{
    public interface IInvoiceService
    {
        Task<Invoice> GetInvoiceByIdAsync(int id);
        Task<IEnumerable<Invoice>> GetAllInvoicesAsync();
        Task CreateInvoiceAsync(Invoice invoice);
        Task UpdateInvoiceAsync(Invoice invoice);
        Task DeleteInvoiceAsync(int id);
    }
}