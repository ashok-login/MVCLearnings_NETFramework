using MVCLearnings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearnings.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id)
        {
            var employees = (new MyDatabaseContext()).Employees.Where(x => x.DepartmentId == id).ToList();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            var context = new MyDatabaseContext();
            var employee = context.Employees.Single(x => x.EmployeeId == id);
            return View(employee);
        }
    }
}
