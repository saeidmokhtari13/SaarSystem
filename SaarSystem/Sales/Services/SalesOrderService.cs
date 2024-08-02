using SaarSystem.Sales.Interfaces;
using SaarSystem.Sales.Models;
using SaarSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaarSystem.Sales.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        private readonly ApplicationDbContext _context;

        public SalesOrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SalesOrder> GetSalesOrderByIdAsync(int id)
        {
            return await _context.SalesOrders.FindAsync(id);
        }

        public async Task<IEnumerable<SalesOrder>> GetAllSalesOrdersAsync()
        {
            return await _context.SalesOrders.ToListAsync();
        }

        public async Task CreateSalesOrderAsync(SalesOrder salesOrder)
        {
            _context.SalesOrders.Add(salesOrder);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSalesOrderAsync(SalesOrder salesOrder)
        {
            _context.SalesOrders.Update(salesOrder);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSalesOrderAsync(int id)
        {
            var salesOrder = await _context.SalesOrders.FindAsync(id);
            if (salesOrder != null)
            {
                _context.SalesOrders.Remove(salesOrder);
                await _context.SaveChangesAsync();
            }
        }
    }
}