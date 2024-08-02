using System.Collections.Generic;
using System.Threading.Tasks;
using SaarSystem.Maintenance.Models;

namespace SaarSystem.Maintenance.Interfaces
{
    public interface IMaintenanceTaskService
    {
        Task<MaintenanceTask> GetMaintenanceTaskByIdAsync(int id);
        Task<IEnumerable<MaintenanceTask>> GetAllMaintenanceTasksAsync();
        Task CreateMaintenanceTaskAsync(MaintenanceTask maintenanceTask);
        Task UpdateMaintenanceTaskAsync(MaintenanceTask maintenanceTask);
        Task DeleteMaintenanceTaskAsync(int id);
    }
}