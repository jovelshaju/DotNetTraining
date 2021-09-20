using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{   
    class Employee2 : IComparable<Employee2>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public int CompareTo(Employee2 other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }


    class SortEmployeeByAge : IComparer<Employee2>
    {
        public int Compare(Employee2 x, Employee2 y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
    class ObjectSort
    {
        public static void ObjectSorting()
        {
            List<Employee2> employees = new List<Employee2>
            {
                new Employee2 { Id = 3, Name = "Mark", Age = 30 },
                new Employee2 { Id = 1, Name = "Paul", Age = 50 },
                new Employee2 { Id = 2, Name = "Watson", Age = 40 }
            };

            Console.WriteLine("Before Sorting...");
            foreach (Employee2 employee in employees)
            {
                Console.WriteLine($"Employee: Id = {employee.Id}, Name = {employee.Name}, Age = {employee.Age}");
            }

            //First Method
            employees.Sort();
            Console.WriteLine("After Sorting by Name...");
            foreach (Employee2 employee in employees)
            {
                Console.WriteLine($"Employee: Id = {employee.Id}, Name = {employee.Name}, Age = {employee.Age}");
            }

            //Second Method
            SortEmployeeByAge sortEmployeeByAge = new SortEmployeeByAge();
            employees.Sort(sortEmployeeByAge);
            Console.WriteLine("After Sorting by Age...");
            foreach (Employee2 employee in employees)
            {
                Console.WriteLine($"Employee: Id = {employee.Id}, Name = {employee.Name}, Age = {employee.Age}");
            }

            //Third Method
            Comparison<Employee2> comparison = (e1, e2) => e1.Id.CompareTo(e2.Id);
            employees.Sort(comparison);
            Console.WriteLine("After Sorting by Id...");
            foreach (Employee2 employee in employees)
            {
                Console.WriteLine($"Employee: Id = {employee.Id}, Name = {employee.Name}, Age = {employee.Age}");
            }


        }
    }
    class ArraySort
    {
        public static void ArraySorting()
        {
            ArrayList al = new ArrayList
            {
                100,
                200,
                500
            };
            al.Insert(1, 300);
            al.Add(400);

            Console.WriteLine("Before Sorting...");
            foreach (int num in al)
            {
                Console.WriteLine(num);
            }

            al.Sort();
            Console.WriteLine("\nAfter Sorting...");
            foreach (int num in al)
            {
                Console.WriteLine(num);
            }

            al.Reverse();
            Console.WriteLine("\nAfter Reverse Sorting...");
            foreach (int num in al)
            {
                Console.WriteLine(num);
            }
        }
    }

    
    class Demo5
    {
        
        public static void Main()
        {
            //ArraySort.ArraySorting();
            ObjectSort.ObjectSorting();
            Console.ReadLine();
        }
    }
}
