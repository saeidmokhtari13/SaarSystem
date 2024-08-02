using SaarSystem.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaarSystem.Maintenance.Models
{
    [Table("MaintenanceTasks", Schema = "CMS")]
    public class MaintenanceTask : BaseEntity
    {
        public string TaskName { get; set; }
        public DateTime ScheduledDate { get; set; }
    }
}