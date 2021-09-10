using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This file contains Excercises done in Day-2.
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddNumbers();
            //TryingIntParsing();
            //UnboxingDemo();
            TryingEqn();

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

        static void TryingIntParsing()
        {
            string val = null;
            int result;
            bool success = int.TryParse(val, out result);
            Console.WriteLine($"{success}");
        }

        static void UnboxingDemo()
        {
            Object MyObj = 30;
            int i = (int)MyObj;
            Console.WriteLine(i);
        }

        static void TryingEqn()
        {

            Console.WriteLine("Function for x=y2+2y+1\n===========");
            while (true)
            {
                Console.WriteLine("Enter y:");
                string input = Console.ReadLine();
                try
                {
                    if (input == "q")
                    {
                        break;
                    }
                    
                    double x = Math.Pow(int.Parse(input), 2) + y * 2 + 1;
                    Console.WriteLine($"x = {(int)x}");
                }
                catch
                {
                    Console.WriteLine("Please Enter an integer");
                }
                
            }
            
        }
    }
}
