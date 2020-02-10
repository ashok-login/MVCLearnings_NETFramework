using MVCLearnings.BLL;
using MVCLearnings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearnings.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult Index(int id)
        {
            var employeesByDeptId = (new MyDatabaseContext()).Employees.Where(x => x.DepartmentId == id).ToList();
            return View(employeesByDeptId);
        }

        public ActionResult Details(int employeeId)
        {
            var emp = (new MyDatabaseContext()).Employees.Where(x => x.EmployeeId == employeeId).SingleOrDefault();
            return View(emp);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            { 
                var empBLL = (new EmployeeBLL()).Create(emp);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
