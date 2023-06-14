using ims.DataAccessLayer.Infrastructure.IRepository;
using Ims.DataAccessLayer;
using Ims.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ims.DataAccessLayer.Infrastructure.Repository
{
    public class EmployeeRepository : Repository<Employees>, IEmployeesRepository
    {
        private readonly imsDbContextFile _context;

        public EmployeeRepository(imsDbContextFile context) : base(context)
        {
            _context = context;
        }

        public void update(Employees employees)
        {
            _context.EmpObj.Update(employees);
        }
    }
}
