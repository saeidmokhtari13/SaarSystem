using SaarSystem.Production.Interfaces;
using SaarSystem.Production.Models;
using SaarSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaarSystem.Production.Services
{
    public class ProductionOrderService : IProductionOrderService
    {
        private readonly ApplicationDbContext _context;

        public ProductionOrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ProductionOrder> GetProductionOrderByIdAsync(int id)
        {
            return await _context.ProductionOrders.FindAsync(id);
        }

        public async Task<IEnumerable<ProductionOrder>> GetAllProductionOrdersAsync()
        {
            return await _context.ProductionOrders.ToListAsync();
        }

        public async Task CreateProductionOrderAsync(ProductionOrder productionOrder)
        {
            _context.ProductionOrders.Add(productionOrder);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductionOrderAsync(ProductionOrder productionOrder)
        {
            _context.ProductionOrders.Update(productionOrder);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductionOrderAsync(int id)
        {
            var productionOrder = await _context.ProductionOrders.FindAsync(id);
            if (productionOrder != null)
            {
                _context.ProductionOrders.Remove(productionOrder);
                await _context.SaveChangesAsync();
            }
        }
    }
}