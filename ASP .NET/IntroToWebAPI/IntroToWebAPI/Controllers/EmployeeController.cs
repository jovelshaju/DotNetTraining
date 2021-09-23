using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IntroToWebAPI.Models;

namespace IntroToWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private static List<Employee> employees;
        private static int count = 3;

        public EmployeeController()
        {
            employees = new List<Employee>() { new Employee { Id = 1, Name = "John", Age = 40 },
                                               new Employee { Id = 1, Name = "John", Age = 40 },
                                               new Employee { Id = 1, Name = "John", Age = 40 }};
        }

        [HttpGet]
        public List<Employee> Get()
        {
            return employees;
        }

        [HttpGet]
        public Employee Get(int id)
        {
            Employee employee = employees.FirstOrDefault(emp => emp.Id == id);
            return employee;
        }

        [HttpPost]
        public Employee Post(Employee employee)
        {
            employee.Id = ++count;
            employees.Add(employee);
            return employee;
        }

        [HttpPut]
        public string Put()
        {
            return "put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "delete";
        }
    }
}
