using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ims.Models
{
    [Table("EmployessView")]

    public class EmployessView
    {
        [Key]
        public int id { get; set; }
        public Employees? Employees { get; set; }
        [Required]
        public int EmployeesId { get; set; }
        public Departments? Departments { get; set; }
        [Required]
        public int DepartmentsId { get; set; }
        public Salaries? salary { get; set; }
        public int salariesId { get; set; }
    }
}
