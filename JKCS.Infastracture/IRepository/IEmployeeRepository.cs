using JKCS.Infastracture.DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKCS.Infastracture.IRepository
{
    public interface IEmployeeRepository : IGenericRepository<Employee>, IDisposable
    {
    }
}
