using MVCLearnings.DAL;
using MVCLearnings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLearnings.BLL
{
    public class EmployeeBLL
    {
        public bool Create(Employee emp)
        {
            return (new EmployeeDAL()).Create(emp);
        }
    }
}
