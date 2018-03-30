using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers.Tests
{


    [TestClass()]
    public class EmployeesControllerTests
    {
        IEmployeeRepository _repository = new EmployeeRepository();
        IList<Employee> empList = new List<Employee>();
        EmployeesController _target;
        public EmployeesControllerTests(IEmployeeRepository employeeRepository)
        {
            _repository = employeeRepository;
            _target = new EmployeesController(_repository);
        }
        [TestInitialize]
        public void TestInitializer()
        {
            
            empList.Add(new Employee { code = "emp101", firstName = "Ashwani", lastName = "Kumar", gender = "Male", age = 23, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Bangalore" } });
            empList.Add(new Employee { code = "emp102", firstName = "Jyoti", lastName = "Kumar", gender = "FeMale", age = 20, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Noida" } });
            empList.Add(new Employee { code = "emp103", firstName = "Atharv", lastName = "Kumar", gender = "Male", age = 24, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Hydrabad" } });
            empList.Add(new Employee { code = "emp104", firstName = "Salini", lastName = "Kumar", gender = "FeMale", age = 25, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "New Delhi" } });
        }

        [TestMethod()]
        public void GetTest()
        {
            //var testProducts = GetTestProducts();

            //var controller = new EmployeesController(_repository);

            var result = _target.Get().ToList<Employee>();

            Assert.IsTrue(result.Count() > 0);
        }
    }
}