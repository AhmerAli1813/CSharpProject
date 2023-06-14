using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ims.Models
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int EId { get; set; }
        [Required(ErrorMessage = "To Username is required.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "To Name is required.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "To password is required.")]
       [MaxLength(20, ErrorMessage = " you leght id icrease"), MinLength(5, ErrorMessage = " you leght id deicrease")]
        [DataType(DataType.Password)]
       public string? Password { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password")] // this is used of compare two colmun  on front base
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "To Date is required.")]
        [DefaultValue("Null")]
         public DateTime JoinDate { get; set; }
        
        
        
        
    }
}
