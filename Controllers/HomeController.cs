using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeSystem.EmployeeData;
using EmployeeSystem.Models;

namespace EmployeeSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private IEmpService _service;

        public HomeController(IEmpService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {

            return _service.GetEmployees();
        }

        [HttpPost]
        public ActionResult<Employee> AddEmployee(Employee employee)
        {
            _service.AddEmployee(employee);
            return employee;
        }
    }
}