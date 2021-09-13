using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{   
    class Calculator
    {
        public int num1, num2;
        public Calculator(int n1, int n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }

        public static Calculator operator -(Calculator c1)
        {
            c1.num1 = -c1.num1;
            c1.num2 = -c1.num2;
            return c1;
        }

        public void print()
        {
            Console.WriteLine($"num1 = {this.num1} | num2 = {this.num2}");
        }
    }
    class OperatorOverload
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator(15, -25);
            calc = -calc;
            calc.print();
            Console.ReadLine();
        }
    }
}
