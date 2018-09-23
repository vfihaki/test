using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Circumference of the  {Circumference(radius)}");
            Console.WriteLine($"The Area {Area(radius)}");
            Console.ReadLine();
        }
        static double Circumference(double radius)
        {
            return 2 * 3.1416 * radius;
        }
        static double Area(double radius)
        {
            return 3.1416 * (radius * radius);
        }

    }
}
