using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("1. Monday");
            Console.WriteLine("2. Tuesday");
            Console.WriteLine("3. Wednesday");
            Console.WriteLine("4. Thursday");
            Console.WriteLine("5. Friday");
            Console.WriteLine("6. Saturday");
            Console.WriteLine("7. Sunday");
            Console.WriteLine("Please pick a number and I will tell you the corresponding day:");
            int input = int.Parse(Console.ReadLine());
            CheckDay(input, days);
            Console.ReadLine();

        }
        public static void  CheckDay(int input, string[] days)
        {
            Console.WriteLine($"The day is: {days[input - 1]}");
        }
    }
}
