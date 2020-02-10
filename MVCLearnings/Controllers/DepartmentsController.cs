using MVCLearnings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearnings.Controllers
{
    public class DepartmentsController : Controller
    {
        public ActionResult Index()
        {
            var departments = (new MyDatabaseContext()).Departments.ToList();
            return View(departments);
        }
    }
}
