using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name..........");
            String name = Console.ReadLine();

            
            Console.WriteLine("Hello {0}, welcome to my application", name);

            Console.WriteLine("Please enter your age..........");
            String age = Console.ReadLine();

            Console.WriteLine("Male or Female..........");
            String gender = Console.ReadLine();

            Console.WriteLine("Please enter your address..........");
            String address = Console.ReadLine();

            Console.WriteLine("Here is your details\n");
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender );
            Console.WriteLine("Address: {0}", address);

            Console.ReadLine();


            Console.WriteLine("Task 2a");
            Console.ReadLine();


            Console.WriteLine("Enter a number");
            Decimal number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            Decimal number2 = Convert.ToInt32(Console.ReadLine());

            Decimal answer = number1 + number2;
            Console.WriteLine("Your answer is: {0}", answer);
            
            Console.ReadLine();

            Console.WriteLine("Task 2b");
            Console.ReadLine();

            Console.WriteLine("Multiplication");
           
            Decimal answer2 = number1 * number2;
            Console.Write("{0}", number1);
            Console.Write("*");
            Console.Write("{0} = ", number2);
            Console.Write(" {0}" , answer2);

            Console.WriteLine("\nDivision");
            
            Decimal answer3 = number1 / number2;
            Console.Write("{0}", number1);
            Console.Write("/");
            Console.Write("{0} = ", number2);
            Console.Write(" {0}", answer3);

            Console.WriteLine("\nSubtraction");
            
            Decimal answer4 = number1 - number2;
            Console.Write("{0}", number1);
            Console.Write("-");
            Console.Write("{0} = ", number2);
            Console.Write(" {0}\n", answer4);

            Console.ReadLine();

            Console.WriteLine("Task 3a");
            Console.ReadLine();

            Console.WriteLine("Please enter your first name:");
            String firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name:\n" +
                "");
            String lastname = Console.ReadLine();

            Console.WriteLine("Your full Detail\n");
            Console.Write("Your full name:");
            Console.Write(" {0}", firstname);
            Console.Write(" {0}\n", lastname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Address: {0}", address);
            /*
            String fullname = firstname + lastname;
            Console.WriteLine("{0}", fullname);
            */
            Console.ReadLine();














        }
    }
}
