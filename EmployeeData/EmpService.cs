using EmployeeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.EmployeeData
{
    public class EmpService : IEmpService
    {
        private List<Employee> _emps;

        public EmpService()
        {
            _emps = new List<Employee>();
        }
        public Employee AddEmployee(Employee emp)
        {
            _emps.Add(emp);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return _emps;
        }
    }
}
