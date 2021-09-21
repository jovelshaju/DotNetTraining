using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class ExceptionHandling
    {
        public static void Demo()
        {
            try
            {
                Console.Write("Enter 1st number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int num2 = int.Parse(Console.ReadLine());
                int z = num1 / num2;
                Console.WriteLine(z);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static void Demo2()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "data.txt");
            StreamReader stream = null;
            try
            {   
                stream = new StreamReader(filePath);
                Console.Write(stream.ReadToEnd());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            
        }
    }

}
