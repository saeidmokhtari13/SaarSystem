using System.Collections.Generic;
using System.Threading.Tasks;
using SaarSystem.Warehouse.Models;

namespace SaarSystem.Warehouse.Interfaces
{
    public interface IInventoryItemService
    {
        Task<InventoryItem> GetInventoryItemByIdAsync(int id);
        Task<IEnumerable<InventoryItem>> GetAllInventoryItemsAsync();
        Task CreateInventoryItemAsync(InventoryItem inventoryItem);
        Task UpdateInventoryItemAsync(InventoryItem inventoryItem);
        Task DeleteInventoryItemAsync(int id);
    }
}