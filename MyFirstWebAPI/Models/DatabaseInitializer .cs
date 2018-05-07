using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstWebAPI.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            base.Seed(context);
            var employee = new List<Employee>
            {
                new Employee { code = "emp101", firstName = "Ashwani", lastName = "Kumar", gender = "Male", age = 23, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Bangalore" }},
                new Employee { code = "emp102", firstName = "Jyoti", lastName = "Kumar", gender = "FeMale", age = 20, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Noida" }},
                new Employee { code = "emp103", firstName = "Atharv", lastName = "Kumar", gender = "Male", age = 24, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Hydrabad" }},
                new Employee { code = "emp104", firstName = "Salini", lastName = "Kumar", gender = "FeMale", age = 25, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "New Delhi" }}
            };
        }
    }
}