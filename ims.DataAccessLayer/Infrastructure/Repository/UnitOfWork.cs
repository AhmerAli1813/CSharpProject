using ims.DataAccessLayer.Infrastructure.IRepository;
using Ims.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims.DataAccessLayer.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly imsDbContextFile _context;
        public IEmployeesRepository employees { get; private set; }
        public UnitOfWork(imsDbContextFile context)
        {
            _context = context;
            employees = new EmployeeRepository(context);
        }

        

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
