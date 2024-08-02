using SaarSystem.Maintenance.Interfaces;
using SaarSystem.Maintenance.Models;
using SaarSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaarSystem.Maintenance.Services
{
    public class MaintenanceTaskService : IMaintenanceTaskService
    {
        private readonly ApplicationDbContext _context;

        public MaintenanceTaskService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<MaintenanceTask> GetMaintenanceTaskByIdAsync(int id)
        {
            return await _context.MaintenanceTasks.FindAsync(id);
        }

        public async Task<IEnumerable<MaintenanceTask>> GetAllMaintenanceTasksAsync()
        {
            return await _context.MaintenanceTasks.ToListAsync();
        }

        public async Task CreateMaintenanceTaskAsync(MaintenanceTask maintenanceTask)
        {
            _context.MaintenanceTasks.Add(maintenanceTask);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMaintenanceTaskAsync(MaintenanceTask maintenanceTask)
        {
            _context.MaintenanceTasks.Update(maintenanceTask);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMaintenanceTaskAsync(int id)
        {
            var maintenanceTask = await _context.MaintenanceTasks.FindAsync(id);
            if (maintenanceTask != null)
            {
                _context.MaintenanceTasks.Remove(maintenanceTask);
                await _context.SaveChangesAsync();
            }
        }
    }
}