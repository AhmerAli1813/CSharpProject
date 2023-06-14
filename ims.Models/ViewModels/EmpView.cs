using Ims.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ims.Models.ViewModels
{
    public class EmpView
    {
        public Employees employees { get; set; } = new Employees();
        public IEnumerable<Employees>EmpList { get; set; } = new List<Employees>();
    }
}
