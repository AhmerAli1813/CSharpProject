
using Ims.Models;
using Microsoft.EntityFrameworkCore;

namespace Ims.DataAccessLayer
{
    public class imsDbContextFile : DbContext
    {
        public imsDbContextFile(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employees> EmpObj { get; set; }
        public DbSet<Departments> DepObj { get; set; }
        public DbSet<Salaries> SalObj { get; set; }
        
    }
}
