using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebAPI.Models
{
    public class EmployeeRepository : IEmployeeRepository<Employee>
    {
        IList<Employee> empList = new List<Employee>();
        public EmployeeRepository()
        {
            empList.Add(new Employee { code = "emp101", firstName = "Ashwani", lastName = "Kumar", gender = "Male", age = 23, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Bangalore" } });
            empList.Add(new Employee { code = "emp102", firstName = "Jyoti", lastName = "Kumar", gender = "FeMale", age = 20, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Noida" } });
            empList.Add(new Employee { code = "emp103", firstName = "Atharv", lastName = "Kumar", gender = "Male", age = 24, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Hydrabad" } });
            empList.Add(new Employee { code = "emp104", firstName = "Salini", lastName = "Kumar", gender = "FeMale", age = 25, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "New Delhi" } });
        }
        public Employee Add(Employee item)
        {
            empList.Add(item);
            return item;
        }

        public Employee Get(string code)
        {
            return empList.FirstOrDefault(e=>e.code==code);
        }

        public IEnumerable<Employee> GetAll()
        {
            return empList.ToList();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}