using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Encapsulation_1
{
    public class Circle
    {
        //hide the data. why?
        //if we change radius to diameter also then clients code will not be impacted
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double area()
        {
            return Math.PI * radius * radius;
        }
        public double perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //we can create any number of circle type objects using circle class
            Circle c1 = new Circle(10.2);
            Console.WriteLine(c1.area());
            Console.WriteLine(c1.perimeter());

            Circle c2 = new Circle(10.2);
            Console.WriteLine(c2.area());
            Console.WriteLine(c2.perimeter());
        }
    }
}
