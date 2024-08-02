using SaarSystem.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaarSystem.Warehouse.Models
{
    [Table("InventoryItems", Schema = "LGS")]
    public class InventoryItem : BaseEntity
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
    }
}