using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {


            String Code;
           
            Boolean menu = true;
            do
            {
                Console.WriteLine("------Welcome to my application-------");
                Console.WriteLine("You may choose from the option below\n");
                Console.WriteLine("Task 1" + " CODE: T1");
                Console.WriteLine("Task 2" + " CODE: T2");
                Console.WriteLine("Task 3" + " CODE: T3");
                Console.WriteLine("");
                Console.WriteLine("Please enter the Code");
                Code = Console.ReadLine().ToUpper();

                if (Code == "T1")
                {
                    MyDetails();

                }

                else if (Code == "T2")
                {
                    MathFunctions(); 

                }
                else if (Code == "T3")
                {
                    FirstnLastName();
                   
                }

                Console.WriteLine("Do you want to choose another task Y/N ?");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }


                Console.Clear();
            } while (menu);



        }

        public static void MyDetails()
        {
            Console.Clear();
            Console.WriteLine("-------YOU CHOOSE-------");
            Console.WriteLine(".......Task 1.......");

            Console.WriteLine("Please enter your name:\n");
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

        }

        public static  void MathFunctions()
        {
            Console.Clear();

            Console.WriteLine("-------YOU CHOOSE-------");
            Console.WriteLine(".........Task 2........");
            /*
            Console.WriteLine("Enter a number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int number2 = int.Parse(Console.ReadLine());

            String choice;
            double result;

            Console.WriteLine("What do you want to do with these number: (+, *, / or -)");

            choice = Console.ReadLine();
            */
            int operation = 0;
            //stock the result of the operation
            double result = 0;
            //Ask user first number
            Console.WriteLine("Type you first number :");
            string stringFirstNumber = Console.ReadLine();
            double firstNumber = Convert.ToDouble(stringFirstNumber);
            //Ask user second number
            Console.WriteLine("Type you second number :");
            string stringSecondNumber = Console.ReadLine();
            double secondNumber = Convert.ToDouble(stringSecondNumber);
            //Ask user operation to use
            Console.WriteLine("Enter the operation + (addition), - (soustraction), * (multiplication), / (division) :");
            string stringOperation = Console.ReadLine();

            // Convert string choice to integral
            if (stringOperation == "+" || stringOperation == "addition")
            {
                operation = 1;
            }
            else if (stringOperation == "-" || stringOperation == "soustraction")
            {
                operation = 2;
            }
            else if (stringOperation == "*" || stringOperation == "multiplication")
            {
                operation = 3;
            }
            else if (stringOperation == "/" || stringOperation == "division")
            {
                operation = 4;
            }
            
            switch (operation)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;

                case 2:
                    result = firstNumber - secondNumber;
                    break;

                case 3:
                    result = firstNumber * secondNumber;
                    break;

                case 4:
                    result = firstNumber / secondNumber;
                    break;   
            }
            Console.WriteLine("\nResult of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result);
            Console.ReadKey();
            

            /*
            Decimal answer = number1 + number2;
            Console.WriteLine("Your answer is: {0}", answer);

            Console.ReadLine();

            Console.WriteLine("\nTask 2b");
            Console.ReadLine();

            Console.WriteLine("Multiplication\n{0} x {1} = {2}", number1, number2, (number1 * number2));

            Console.WriteLine($"{number1} x {number2} = {(number1 * number2)}");
            Console.WriteLine(number1 + " x " + number2 + " = " + (number1 * number2));

            Console.WriteLine("\nDivision\n{0} / {1} = {2}", number1, number2, (number1 / number2));

            Console.WriteLine("\nSubtraction\n{0} - {1} = {2}", number1, number2, (number1 - number2));
            Console.ReadLine();
            


            Console.WriteLine(number2 + choice + number2);
            //Console.Write("The end result is: {0}\n You are most welcome!)\n", final);
            Console.ReadLine();
            */
        }

        public static void FirstnLastName()
        {
            Console.Clear();
           
            Console.WriteLine("-----YOU CHOOSE----");
            Console.WriteLine(".........Task 3a.........");
            Console.ReadLine();

            Console.WriteLine("Please enter your first name:");
            String firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            String lastname = Console.ReadLine();

            Console.WriteLine("Your full name: {0} {1}", firstname, lastname);

        }
    }
}
