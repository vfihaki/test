using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] category = { "underweight", "Normal weight", "Overweight", "Obese" };
            Console.Write("Please enter the Weight in kg: ");
            double Weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter the Height in cm: ");
            double Height = double.Parse(Console.ReadLine())/100;
            Console.WriteLine($"Your BMI {Total(Weight,Height)}");
            


            Console.ReadLine();
        }
        static double Total(double Weight, double Height)
        {
            return Weight / (Height * Height);
        }
        public static void BMICategory(double Total)
        {
            if(Total < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if(Total >= 18.5 && Total < 25)
            {
                Console.WriteLine("Normal weight");
            }
            else if (Total >= 25 && Total < 30)
            {
                Console.WriteLine("Overweight");
            }
            else if (Total >= 30)
            {
                Console.WriteLine("Obese");
            }
        }
        
    }
}
