using EmployeeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.EmployeeData
{
   public interface IEmpService
    {
        public List<Employee> GetEmployees();
        public Employee AddEmployee(Employee emp);

    }
}
