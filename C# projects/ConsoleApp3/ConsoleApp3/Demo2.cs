using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    delegate bool IsPromoted(Employee employee);
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromotedEmployee(List<Employee> list, IsPromoted isPromoted)
        {
            foreach (Employee employee in list)
            {
                if (isPromoted(employee))
                {
                    Console.WriteLine(employee.Name + " - Promoted");
                }
            }
        }

    }

    class Demo2
    {
        static void Main3()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 101, Name = "Mark", Salary = 5000, Experience = 3 });
            employees.Add(new Employee() { Id = 102, Name = "Smith", Salary = 3000, Experience = 5 });
            employees.Add(new Employee() { Id = 103, Name = "Watson", Salary = 6000, Experience = 8 });
            employees.Add(new Employee() { Id = 104, Name = "Paul", Salary = 8000, Experience = 4 });

            IsPromoted isPromoted = new IsPromoted(PromotedLogic);

            Employee.PromotedEmployee(employees, isPromoted);


            Console.ReadKey();
        }

        public static bool PromotedLogic(Employee employee)
        {
            if (employee.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
