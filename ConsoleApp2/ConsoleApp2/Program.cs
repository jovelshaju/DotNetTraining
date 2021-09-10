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
        static void NestedArrayDemo()
        {
            int[,,] arrd3 = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6} }, { { 7, 8, 9 }, { 10, 11, 12} } };
            int[,] arr = { { 1, 2, 3 }, { 1,2,1 } };
        }

        static void SearchingArray()
        {
            string[] names = { "Vinay", "Bill", "Bill Gates", "Lazar", "Mohan", "Nikhil", "Boski" };
            var stringToFind = "Vinay";

            var result = Array.Find(names, element => element == stringToFind);
            Console.WriteLine(result);
        }

        static void CountingElements()
        {
            int[] numsArray = {5,7,9,15,6,3,54,31 };
            var theCount = numsArray.Count(n => n % 3 == 0);
            Console.WriteLine(theCount);
        }

        static void  MergingArrays()
        {
            int[] numArray1 = { 1,3,5,7};
            int[] numArray2 = { 2,4,6,8 };

            var all = numArray1.Union(numArray2).ToArray();
            Console.WriteLine(all);
        }

        static void UsingJoin()
        {
            int[] nums = { 1, 2, 3, 4 };
            var str = String.Join(",", nums);

            Console.WriteLine(str);
        }

        static void UsingDistinct()
        {
            string[] names = { "Vinay", "Bill", "Vinay", "Lazar", "Mohan", "Nikhil", "Boski" };
            string[] dist = names.Distinct().ToArray();

            Console.WriteLine(dist);
        }

        static void SortingArray()
        {
            string[] names = { "Vinay", "Bill",  "Lazar", "Mohan", "Nikhil", "Boski" };
            Array.Sort(names);

            Console.WriteLine(names);
        }
    }
}
