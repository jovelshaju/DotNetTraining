using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Shape
    {
        public Shape() //Super Constructor
        {
            
            Console.WriteLine("Inside Super");
        }
        public double height { get; set; }
        public double width { get; set; }
    }

    class Triangle : Shape
    {
        //string kind;

        static Triangle() //Static initialization
        {
            string DateofCreation = DateTime.Now.ToString();
            Console.WriteLine(DateofCreation);
        }

        
        public Triangle(double width, double height) : this(width)//Parametrised Constructor
        {
            this.height = height;
        }

        public Triangle(double width) : base()
        {
            this.width = width;
        }

    }
    class OOPSBasics
    {
        public void OOPSDemo()
        {
            Triangle t1 = new Triangle(10.2, 12.4);
            Triangle t2 = t1;
            Console.WriteLine(t2 == t1);
            Triangle triangleWithWidth = new Triangle(30.5);
            Console.WriteLine(triangleWithWidth.width);
        }
    }
}
