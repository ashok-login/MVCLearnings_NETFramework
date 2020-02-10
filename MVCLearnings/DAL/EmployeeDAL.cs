using MVCLearnings.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCLearnings.DAL
{
    public class EmployeeDAL : DbContext
    {
        public bool Create(Employee emp)
        {
            var context = new MyDatabaseContext();
            context.Employees.Add(emp);
            return context.SaveChanges() > 0;
        }
    }
}
