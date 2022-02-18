using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task_2.FakeData;
using Task_2.Models;
using System.Linq;

namespace Task_2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private List<Employee> _employees = FakeDataCreation.GetEmployees(10);

        [HttpGet("get")]
        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        [HttpGet("get/{id}")]
        public Employee GetEmployeeById(int id)
        {
            var employee = _employees.FirstOrDefault(emp => emp.Id == id);

            return employee;
        }

        [HttpPost("create")]
        public Employee CrerateEmployee([FromBody] Employee employee)
        {
            _employees.Add(employee);

            return employee;
        }

        [HttpPut("update")]
        public Employee UpdateEmployee([FromBody] Employee employee)
        {
            var editedEmployee = _employees.FirstOrDefault(e => e.Id == employee.Id);

            editedEmployee.Position = employee.Position;
            editedEmployee.Salary = employee.Salary;
            editedEmployee.IsManager = employee.IsManager;

            return employee;
        }

        [HttpDelete("delete")]
        public Employee DeleteEmployee(int id)
        {
            var employee = _employees.FirstOrDefault(emp => emp.Id == id);

            _employees.Remove(employee);

            return employee;
        }
    }
}
