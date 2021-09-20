using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{   
    class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }

    class StudentDemo
    {
        public void Demo()
        {
            List<Student> StudentList = new List<Student>
            {
                new Student { Id = 101, Name = "Peter", Age = 20 },
                new Student { Id = 301, Name = "Liam", Age = 23 },
                new Student { Id = 201, Name = "Chris", Age = 19 }
            };

            Console.WriteLine("Student Data: ");
            foreach (Student student in StudentList)
            {
                Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Age: {student.Age}");
            }

            Console.WriteLine("\nAfter Sorting By Age: ");
            StudentList.Sort();
            foreach (Student student in StudentList)
            {
                Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Age: {student.Age}");
            }

            Console.WriteLine("\nAfter Sorting By Name: ");
            Comparison<Student> comparison = (e1, e2) => e1.Name.CompareTo(e2.Name);
            StudentList.Sort(comparison);
            foreach (Student student in StudentList)
            {
                Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Age: {student.Age}");
            }

        }
    }
    class Excercises
    {
        public void ReverseString()
        {
            Console.WriteLine("Enter the string to be reversed: ");
            string input = Console.ReadLine();
            string ReverseInput = "";
            for (int i = input.Length-1; i >=0 ; i--)
            {
                ReverseInput += input[i];
            }
            
            Console.WriteLine(ReverseInput);
            Console.WriteLine(input);
        }

        public void Largestnumber()
        {
            Console.WriteLine("Enter the array: ");
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            foreach (string num in input.Split(' '))
            {
                int result =  int.Parse(num);
                numbers.Add(result);
            }
            numbers.Reverse();
            Console.WriteLine("Largest Number in the array: {0}", numbers[0]);
        }
        public void SwappingNumbers()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("After Swapping...");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a: {a} b: {b}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Excercises e1 = new Excercises();
            //e1.ReverseString();
            //e1.Largestnumber();;
            //e1.SwappingNumbers();

            StudentDemo s1 = new StudentDemo();
            s1.Demo();

            Console.ReadLine();
        }
    }
}
