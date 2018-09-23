using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please enter a letter and i will tell you whether its a vowel or consonant: ");
            string letter1 = Console.ReadLine();

            if (letter1 == "a" || letter1 == "e" || letter1 == "i" || letter1 == "o" || letter1 == "u")
            Console.WriteLine("{0} is a vowel", letter1);

            else
            {
                Console.WriteLine("{0} is a consonant", letter1);
            }
            
            Console.ReadLine();

            Console.Write("Please enter your body weight in kgs:");
            float bw = float.Parse(Console.ReadLine());

            Console.Write("\nNow please enter your height in meters:");
            float bh = float.Parse(Console.ReadLine())/100;

            Console.WriteLine("Your BMI is: {0} ", (bw / (bh * bh)));
            Console.Write("Press Enter to quit.....");
            Console.ReadLine();

            float total = 0;
            for(int i = 1; i <= 20; i ++)
            {
                Console.Write("Please enter number {0}:  ", i);
                total = total + float.Parse(Console.ReadLine());
            }

            Console.WriteLine("The total of the  number you enter: {0}", total);

            Console.ReadLine();
            */
            float total = 1;
            int j = 1;
            while (j <= 10)
            {
                total *= j;
                j++;
            }
            Console.WriteLine("{0}", total);

            Console.ReadLine();

        }
    }
}
