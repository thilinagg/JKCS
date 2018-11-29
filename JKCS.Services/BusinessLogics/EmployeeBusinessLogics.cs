using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKCS.Core.Entities;
using JKCS.Infastracture.DBConnection;
using JKCS.Infastracture.IRepository;
using JKCS.Infastracture.Repository;
using JKCS.Services.Interfaces;

namespace JKCS.Services.BusinessLogics
{
    public class EmployeeBusinessLogics : IEmployeeBusinessLogics
    {
        private readonly EmployeeDBEntities context;
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeBusinessLogics()
        {
            context = new EmployeeDBEntities();
            employeeRepository = new EmployeeRepository(context);
        }


        public EmployeeEntity InsertEmployeeDataBL(EmployeeEntity entity)
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
                var response = employeeRepository.Insert(employee);

                if (response != null)
                {
                    entity.ID = response.ID;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return entity;
        }

        public List<EmployeeEntity> GetEmployeeDetailsBL()
        {
            var employeDetails = employeeRepository.GetAll()
                .Select(e => new EmployeeEntity
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Position = e.Position
                }).ToList();

            return employeDetails;
        }
        public List<EmployeeEntity> GetEmployeeDetailsBL(int employeeID)
        {
            var employeDetails = employeeRepository.GetList(e=>e.ID == employeeID)
                .Select(e => new EmployeeEntity
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Position = e.Position
                }).ToList();

            return employeDetails;
        }

    }
}
