using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{   
    class Calculator
    {
        public static void AreEqual<T> (T var1, T var2)
        {
            if (var1.Equals(var2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.AreEqual<int> (10, 20);
            Console.ReadKey();
        }
    }
}
