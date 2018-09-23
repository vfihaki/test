using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 
            Console.WriteLine("------For Loop------");
            Console.WriteLine("Enter a starting number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an end number:");
            int num2 = int.Parse(Console.ReadLine());
            for(int i = num1; i <= num2; i ++)
            {
                Console.WriteLine("{0}   {1}  {2}  {3}", i, (i*10), (i*100), (i*1000) );
            }
            Console.WriteLine("------While Loop------");
            int j = num1;
            while (j <= num2)
            {

                Console.WriteLine("{0}   {1}  {2}  {3}", j, (j * 10), (j * 100), (j * 1000));
                j++;
                
            }
            Console.WriteLine("------Do/While Loop------");
            int n = num1;
            do
            {

                Console.WriteLine("{0}   {1}  {2}  {3}", n, (n * 10), (n * 100), (n * 1000));
               n++;
            }
            while (n <= num2);

            Console.WriteLine("----Task 2------");
            
   
            Console.WriteLine("Enter any number for multiplication:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("------For Loop------");
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine("{0} x {1} = {2}  ", a, start, (a * start));
            }
            Console.WriteLine("------While Loop------");
            int b = 1;
            while (b <= 12 )
            {
                Console.WriteLine("{0} x {1} = {2}  ", b, start, (b * start));
                b++;
            }
            Console.WriteLine("------Do/While Loop------");
            int c = 1;
            do
            {
                Console.WriteLine("{0} x {1} = {2}  ", c, start, (c * start));
                c++;
                
            }
            while (c <= 12);
      
            Console.WriteLine("-------Task 3-------");

            Console.WriteLine("Enter a number:");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("------For Loop------");
            for (int d = one; d <= 10; d++)
            {
                Console.WriteLine("{0}   {1}  {2} ", d, (d * d), (d*d*d) );
            }
            Console.WriteLine("------While Loop------");
            int e = one;
            while(e <= 10)
            {
                Console.WriteLine("{0}   {1}  {2} ", e, (e * e), (e * e * e));
                    e++;
            }
            Console.WriteLine("------Do/While Loop------");
            int f = one;
            do
            {
                Console.WriteLine("{0}   {1}  {2} ", f, (f * f), (f * f * f));
                f++;
            }
            while (f <= 10);


            Console.ReadLine();
            Console.WriteLine("-----------Loops and if's-------------------");
            Console.WriteLine("-------Task 1----------");

            int g = 75;
            while (g > 46)
            {
                if (g % 2 != 46)
                {
                    Console.WriteLine("{0}", g--);
                }
                g--;
            }
            */

            Console.WriteLine("-------Task 2----------");

            Console.WriteLine("Enter a number:");
            int numb1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a symbol:");
            char symb = char.Parse(Console.ReadLine());

            Console.WriteLine("------For Loop------");
            for (int h = 1; h <= numb1; h++)
            {
                Console.Write("{0}", (symb));
            }

            Console.WriteLine("\n------While Loop------");
            int k = numb1;
            while (k <= symb)
            {
                Console.Write("{0}", (symb));
                k++;
            }
            Console.WriteLine("\n------Do/While Loop------");
            int l = numb1;
            do
            {

                Console.Write("{0}", (symb));
                l++;
            }
            while (l <= symb);



            Console.ReadLine();











        }
    }
}
