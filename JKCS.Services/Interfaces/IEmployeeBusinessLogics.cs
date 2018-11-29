using JKCS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKCS.Services.Interfaces
{
    public interface IEmployeeBusinessLogics
    {
        EmployeeEntity InsertEmployeeDataBL(EmployeeEntity entity);
        List<EmployeeEntity> GetEmployeeDetailsBL();
        List<EmployeeEntity> GetEmployeeDetailsBL(int employeeID);
    }
}
