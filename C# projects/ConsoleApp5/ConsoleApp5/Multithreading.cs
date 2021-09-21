using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp5
{
    class Multithreading
    {
        public static void Task1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task 1: " + i);
            }
        }

        public static void Task2()
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Task 2: " + i);
                if (i == 5)
                {
                    Console.WriteLine("sleeping...");
                    Thread.Sleep(2000);
                    Console.WriteLine("woke up");
                }
            }
        }

        public static void Task3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task 3: " + i);
            }
        }

        public static void Demo()
        {
            Thread t1 = new Thread(Task1);
            Thread t2 = new Thread(Task2);
            Thread t3 = new Thread(Task3);

            t1.Start();
            t2.Start();
            t3.Start();


            Console.ReadLine();
        }
    }
}
