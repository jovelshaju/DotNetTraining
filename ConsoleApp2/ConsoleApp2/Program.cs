using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers();
            Console.ReadLine();

        }

        static void AddNumbers()
        {
            Console.WriteLine("\nFunction to Add Two Numbers\n===================");
            Console.WriteLine("Enter first number:");
            dynamic num1 = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            dynamic num2 = Console.ReadLine();

            num1 = int.Parse(num1);
            num2 = int.Parse(num2);
            int sum = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");

        }
    }
}
