using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".......Task 1a.......");
            Console.ReadLine();

            Console.WriteLine("Please enter your name..........\n");
            String name = Console.ReadLine();

            
            Console.WriteLine("Hello {0}, welcome to my application\n", name);

            Console.WriteLine(".......Task 1b.......");
            Console.ReadLine();

            Console.WriteLine("How old are you");
            String age = Console.ReadLine();

            Console.WriteLine("Male or Female?");
            String gender = Console.ReadLine();

            Console.WriteLine("Please enter your address.");
            String address = Console.ReadLine();

            Console.WriteLine("\nHere is your details:");
            Console.WriteLine("Age: {0}\nGender: {1}\nAddress: {2}", age, gender, address);
            Console.ReadLine();

            Console.WriteLine(".........Task 2a........");
            Console.ReadLine();


            Console.WriteLine("Enter a number");
            Decimal number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            Decimal number2 = int.Parse(Console.ReadLine());

            Decimal answer = number1 + number2;
            Console.WriteLine("Your answer is: {0}", answer);
            
            Console.ReadLine();

            Console.WriteLine("\nTask 2b");
            Console.ReadLine();

            Console.WriteLine("Multiplication\n{0} x {1} = {2}", number1, number2, (number1*number2));
            /*
            Console.WriteLine($"{number1} x {number2} = {(number1 * number2)}");
            Console.WriteLine(number1 + " x " + number2 + " = " + (number1*number2));        
            */
            Console.WriteLine("\nDivision\n{0} / {1} = {2}", number1, number2, (number1 / number2));

            Console.WriteLine("\nSubtraction\n{0} - {1} = {2}", number1, number2, (number1 - number2));
            Console.ReadLine();

            Console.WriteLine(".........Task 3a.........");
            Console.ReadLine();

            Console.WriteLine("Please enter your first name:");
            String firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            String lastname = Console.ReadLine();

            Console.WriteLine("\nYour full Detail\n"); 
            Console.WriteLine("Your full name: {0} {1}\nAge: {2}\nGender: {3}\nAddress: {4}\n\n", firstname, lastname, age, gender, address);                   
          
            Console.WriteLine("Press any key to ............");
            Console.ReadKey();














        }
    }
}
