using Microsoft.EntityFrameworkCore;
using MyWebAppDemo.Models;

namespace MyWebAppDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<userModel> Users { get; set; }

    }
}
