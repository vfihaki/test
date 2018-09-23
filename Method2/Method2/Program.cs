using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a number:");
            double numb1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"When convert {numb1} kilometer to miles is: {Conversion(numb1)} miles");
            Console.ReadLine();
        }
        static double Conversion(double numb1)
        {
            return numb1 * 0.62137;
        }
    }
}
