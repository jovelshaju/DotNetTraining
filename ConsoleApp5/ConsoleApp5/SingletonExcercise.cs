using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{   
    sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton initialize = null;

        public static Singleton GetInstance
        {
            get
            {
                if (initialize == null)
                {
                    initialize = new Singleton();
                }
                return initialize;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");
        }
    }
    class SingletonExcercise
    {
        static void Main()
        {
            Singleton s1 = Singleton.GetInstance;
            Singleton s2 = Singleton.GetInstance;
            Singleton s3 = Singleton.GetInstance;

            Console.ReadKey();
        }
    }
}
