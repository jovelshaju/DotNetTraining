using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Calculator
    {
        public static double AddNumber1(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void AddNumber2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            else
                return false;
        }
    }
    class Demo4
    {
        static void Main5()
        {
            //Delegate1 d1 = Calculator.AddNumber1;
            //Delegate2 d2 = Calculator.AddNumber2;
            //Delegate3 d3 = Calculator.CheckLength;

            Func<int, float, double, double> d1 = Calculator.AddNumber1;
            Action<int, float, double> d2 = Calculator.AddNumber2;
            Predicate<string> d3 = Calculator.CheckLength;

            double d = d1.Invoke(100, 123.45f, 123.45);
            Console.WriteLine(d);
            d2.Invoke(100, 123.45f, 123.45);
            bool b = d3.Invoke("Hello2");
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
