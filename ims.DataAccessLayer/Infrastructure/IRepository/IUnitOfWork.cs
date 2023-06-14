using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims.DataAccessLayer.Infrastructure.IRepository
{
    public interface IUnitOfWork
    {
        IEmployeesRepository employees { get; }
        void Save();
    }
}
