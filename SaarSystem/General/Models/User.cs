using SaarSystem.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaarSystem.General.Models
{
    [Table("Users", Schema = "GNR")]
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}