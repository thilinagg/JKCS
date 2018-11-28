using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKCS.Core.Entities;
using JKCS.Core.IRepository;
using JKCS.Infastracture.DBConnection;
using JKCS.Infastracture.Repository;

namespace JKCS.Services.BusinessLogics
{
    public class EmployeeBusinessLogics
    {
        private readonly EmployeeDBEntities context;
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeBusinessLogics()
        {
            context = new EmployeeDBEntities();
            employeeRepository = new EmployeeRepository(context);
        }

        public EmployeeEntity InsertEmployeeData(Employee entity)
        {
            try
            {
                Employee employee = new Employee
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Mobile = entity.Mobile,
                    Position = entity.Position
                };
                //var response = employeeRepository.Insert(employee);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
