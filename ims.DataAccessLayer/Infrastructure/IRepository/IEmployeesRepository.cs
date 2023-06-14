using Ims.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims.DataAccessLayer.Infrastructure.IRepository
{
    public interface IEmployeesRepository :IRepository<Employees>
    {
        void update(Employees employees);
    }
}
