using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate void RectangleDelegate(double w, double h);
    class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area: " + (width * height));
        }

        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Parameter: " + (2 * (width + height)));
        }
    }
    class Demo3
    {
        static void Main4(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            //RectangleDelegate rd = new RectangleDelegate(rectangle.GetArea);
            RectangleDelegate rd = rectangle.GetArea;
            rd += rectangle.GetPerimeter;

            rd.Invoke(12.34, 56.78);


            Console.ReadKey();

        }
    }
}
