using System.Collections.Generic;
using System.Threading.Tasks;
using SaarSystem.Production.Models;

namespace SaarSystem.Production.Interfaces
{
    public interface IProductionOrderService
    {
        Task<ProductionOrder> GetProductionOrderByIdAsync(int id);
        Task<IEnumerable<ProductionOrder>> GetAllProductionOrdersAsync();
        Task CreateProductionOrderAsync(ProductionOrder productionOrder);
        Task UpdateProductionOrderAsync(ProductionOrder productionOrder);
        Task DeleteProductionOrderAsync(int id);
    }
}