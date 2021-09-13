using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class RefAndOut
    {

        public static void Main(string[] args)
        {
            //OutDemo();
            RefDemo();
            Console.Read();
        }

        private static void RefDemo()
        {
            string str1 = "Peter";
            SetValue(ref str1);
            Console.WriteLine(str1);
        }

        private static void SetValue(ref string str)
        {
            str = "Quill";
        }

        private static void OutDemo()
        {
            int result;
            bool returnedValue = Add(out result, 500);
            Console.WriteLine(result);
            Console.WriteLine(returnedValue);
        }

        public static bool Add (out int a, int b)
        {
            a = 10;
            a = a + a;
            Console.WriteLine(b);
            return true;
        } 
    }
    
}
