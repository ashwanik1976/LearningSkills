using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstWebAPI.Models;
using System.Net.Http;
using Moq;

namespace MyFirstWebAPI.Controllers.Tests
{


    [TestClass()]
    public class EmployeesControllerTests
    {
        IEmployeeRepository _repository = new EmployeeRepository();
       // IList<Employee> empList = new List<Employee>();

        Mock<IEmployeeRepository> _employeeRepositoryMock = new Mock<IEmployeeRepository>();
        EmployeesController _target;
        //public EmployeesControllerTests(IEmployeeRepository employeeRepository)
        //{
        //    _repository = employeeRepository;
        //    _target = new EmployeesController(_repository);
        //}
        [TestInitialize]
        public void TestInitializer()
        {
            _employeeRepositoryMock.Setup(x => x.GetAll()).Returns(new List<Employee> { 
                new Employee { code = "emp101", firstName = "Ashwani", lastName = "Kumar", gender = "Male", age = 23,Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Bangalore" } } });
            _target = new EmployeesController(_employeeRepositoryMock.Object);
        }

        [TestMethod()]
        public void GetTest()
        {
            //var testProducts = GetTestProducts();

            //var controller = new EmployeesController(_repository);

            var result = _target.Get();

            //Assert.IsTrue(result.Count() > 0);
            Assert.IsNotNull(result);
            //Assert.IsNotNull(result.StatusCode);
        }
    }
}