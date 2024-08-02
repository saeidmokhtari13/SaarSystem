using System.Collections.Generic;
using System.Threading.Tasks;
using SaarSystem.Sales.Models;

namespace SaarSystem.Sales.Interfaces
{
    public interface ISalesOrderService
    {
        Task<SalesOrder> GetSalesOrderByIdAsync(int id);
        Task<IEnumerable<SalesOrder>> GetAllSalesOrdersAsync();
        Task CreateSalesOrderAsync(SalesOrder salesOrder);
        Task UpdateSalesOrderAsync(SalesOrder salesOrder);
        Task DeleteSalesOrderAsync(int id);
    }
}