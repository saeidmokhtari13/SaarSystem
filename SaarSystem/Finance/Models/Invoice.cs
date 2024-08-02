using SaarSystem.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaarSystem.Finance.Models
{
    [Table("Invoices", Schema = "FIN")]
    public class Invoice : BaseEntity
    {
        public string? InvoiceNumber { get; set; } // nullable string
        public decimal? Amount { get; set; } // nullable decimal
        public DateTime? InvoiceDate { get; set; } // nullable DateTime
    }
}