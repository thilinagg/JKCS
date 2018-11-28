using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKCS.Core.Entities;

namespace JKCS.Core.IRepository
{
    public interface IEmployeeRepository: IGenericRepositiory<EmployeeEntity>, IDisposable
    {
    }
}
