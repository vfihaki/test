using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The input {num1} change is: {Sign(num1)}");
        }
        static int Sign(int num1)
        {
            return num1 * -1;
        }
    }
}
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            double numb1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"When convert{numb1}km to {Conversion(numb1)}miles");
           

        }
        static double Conversion(double numb1)
        {
            return numb1 * 0.62137;
        }
    }

}

