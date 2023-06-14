using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ims.Models
{
    [Table("Departments")]
    public class Departments
    {
        [Key]
        [Required]
        public int DId { get; set; }
        [Required]
        [StringLength(50)]
        public string? DName { get; set; }
        [Required]
        [StringLength(50)]
        public string? Designation { get; set; }
    }
}
