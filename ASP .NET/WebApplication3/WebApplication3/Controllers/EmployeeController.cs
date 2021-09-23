using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : ApiController
    {
        private static List<Employee> employees = new List<Employee>() { new Employee { Id = 1, Name = "John", Age = 40 },
                                               new Employee { Id = 2, Name = "Peter", Age = 30 },
                                               new Employee { Id = 3, Name = "Doe", Age = 35 }};
        

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
            employee.Id = employees.Count + 1;
            employees.Add(employee);
            return employee;
        }

        [HttpPut]
        public Employee Put(int id, Employee employee_update)
        {
            Employee employee = employees.FirstOrDefault(emp => emp.Id == id);
            //employees.Remove(employee);
            //employees.Insert(employee_new.Id - 1, employee_new);
            int index = employees.IndexOf(employee);
            employees[index] = employee_update;
            return employee_update;
        }

        [HttpDelete]
        public Employee Delete(int id)
        {
            Employee employee = employees.FirstOrDefault(emp => emp.Id == id);
            employees.Remove(employee);
            return employee;
        }
    }
}
