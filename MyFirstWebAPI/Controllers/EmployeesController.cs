using MyFirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyFirstWebAPI.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeesController : ApiController
    {

        IEmployeeRepository _repository=new EmployeeRepository();
        //public EmployeesController()
        //{ }
        public EmployeesController(IEmployeeRepository repository)
        {
            //empList.Add(new Employee { code = "emp101", firstName = "Ashwani", lastName = "Kumar", gender = "Male", age = 23, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Bangalore" } });
            //empList.Add(new Employee { code = "emp102", firstName = "Jyoti", lastName = "Kumar", gender = "FeMale", age = 20, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Noida" } });
            //empList.Add(new Employee { code = "emp103", firstName = "Atharv", lastName = "Kumar", gender = "Male", age = 24, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "Hydrabad" } });
            //empList.Add(new Employee { code = "emp104", firstName = "Salini", lastName = "Kumar", gender = "FeMale", age = 25, Address = new Address { HouseNumber = 1, Village = "Honagasandra", City = "New Delhi" } });
            _repository = repository;
        }
        [Route("")]
        public IEnumerable<Employee> Get() =>
            //return empList;
            //return null;
            _repository.GetAll();

        [Route("{code}")]
        [HttpGet]
        public IHttpActionResult Get(string code)
        {
            //var employee =  empList.Where(e => e.code == code.ToString()).FirstOrDefault();
            var employee = _repository.Get(code);
            if (employee == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }
            //return Request.CreateResponse(employee);
            return Ok(employee);
        }
        
        [Route("{code}/address")]
        [HttpGet]
        public IHttpActionResult GetAddress(string code)

        {
            var employee = _repository.Get(code);
            if (employee == null)
            {
                // throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }
            return Ok(employee.Address);
           // return Request.CreateResponse(employee.Address); 
        }
        public IHttpActionResult Post(Employee employee)
        {
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee); ;
        }
    }
}
