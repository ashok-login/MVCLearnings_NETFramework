using Revision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revision.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var emp = (new MyDatabaseContext()).Employees.Where(x => x.EmployeeId == id).SingleOrDefault();
            return View(emp);
        }
    }
}