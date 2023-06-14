using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ims.Models
{
    [Table("Salaries")]

    public class Salaries
    {
        public enum Month
        {
            jan, feb, mar, apr, may, jun, jul, aug, sep, december,
        }
        public int Id { get; set; }
        [Required]
        public Month EMonth { get; set; }
        [Required]
        public DateTime Edate { get; set; }
        [Required(ErrorMessage = "To salary amount is required.")]
        public float EAmount { get; set; }
        public Employees? Employees { get; set; }
        [Required]
        public int EmployeesId { get; set; }
        public Departments? Departments  { get; set; }
        [Required]
        public int DepartmentsId { get; set; }
    }
}
