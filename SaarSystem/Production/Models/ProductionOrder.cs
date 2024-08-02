using SaarSystem.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaarSystem.Production.Models
{
    [Table("ProductionOrders", Schema = "PRD")]
    public class ProductionOrder : BaseEntity
    {
        public string OrderNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}