using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyFirstWebAPI.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() : base("DefaultConnection") { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}