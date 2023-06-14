using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ims.DataAccessLayer;

namespace ims.DataAccessLayer
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<imsDbContextFile>
    {
        public imsDbContextFile CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<imsDbContextFile>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-3OKF36U\\MSSQLSERVER01; Database=IvsMvcDb; Integrated Security=true; MultipleActiveResultSets=true; Trusted_Connection=True");

            return new imsDbContextFile(optionsBuilder.Options);
        }
    }
}
