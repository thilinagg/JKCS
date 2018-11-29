using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JKCS.Core.Entities;
using JKCS.Services.BusinessLogics;
using JKCS.Services.Interfaces;

namespace JKCS.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBusinessLogics employeeBusiness;

        public EmployeeController()
        {
            employeeBusiness = new EmployeeBusinessLogics();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertEmployeData(EmployeeEntity employeeEntity)
        {

            var response = employeeBusiness.InsertEmployeeDataBL(employeeEntity);
            return Json(new { response });
        }

        public ActionResult GetAllEmployeeList()
        {

            var response = employeeBusiness.GetEmployeeDetailsBL();
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}