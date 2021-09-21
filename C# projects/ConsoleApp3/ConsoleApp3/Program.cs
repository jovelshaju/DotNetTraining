using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate void AddNumberDelegate(int x, int y);
    public delegate string DisplayNameDelegate(string str);

    public class Test
    {
        public void AddNumber(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string DisplayName(string name)
        {
            return "Hello " + name;
        }
    }

    class Demo1
    {
        static void Main2(string[] args)
        {
            Test test = new Test();
            // test.AddNumber(10, 20);
            //string message=  Test.DisplayName("Jogn");
            // Console.WriteLine(message);

            // initialization
            AddNumberDelegate ad = new AddNumberDelegate(test.AddNumber);
            DisplayNameDelegate dn = new DisplayNameDelegate(Test.DisplayName);

            // invoke
            ad(10, 20);
            string str = dn("Mark");
            Console.WriteLine(str);


            Console.ReadKey();
        }
    }
}
