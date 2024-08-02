using System.Collections.Generic;
using System.Threading.Tasks;
using SaarSystem.Procurement.Models;

namespace SaarSystem.Procurement.Interfaces
{
    public interface IPurchaseOrderService
    {
        Task<PurchaseOrder> GetPurchaseOrderByIdAsync(int id);
        Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrdersAsync();
        Task CreatePurchaseOrderAsync(PurchaseOrder purchaseOrder);
        Task UpdatePurchaseOrderAsync(PurchaseOrder purchaseOrder);
        Task DeletePurchaseOrderAsync(int id);
    }
}