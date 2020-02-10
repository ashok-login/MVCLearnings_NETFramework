using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Revision.Models
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}