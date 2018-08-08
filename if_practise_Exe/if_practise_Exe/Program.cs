using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_practise_Exe
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
                Console.WriteLine("You may choose from the following IF Practice Exercises below\n");
                Console.WriteLine("Exercise 1: Comparing Integers\t\t" +" CODE: E1");
                Console.WriteLine("Exercise 2: Guess My Number\t\t" +        " CODE: E2");
                Console.WriteLine("Exercise 3: Grade\t\t\t" +                  " CODE: E3");
                Console.WriteLine("Exercise 4: Odd n Even\t\t\t" +             " CODE: E4");
                Console.WriteLine("Exercise 5: New PIN Number Program\t" + " CODE: E5");
                Console.WriteLine("Exercise 6: Palindrome Program\t\t" +     " CODE: E6");
                Console.Write("\nPlease enter the CODE:");
                Code = Console.ReadLine().ToUpper();

                if (Code == "E1")
                {
                    ComparingIntegers();
                }

                else if (Code == "E2")
                {
                    GuessMyNumber();
                }
                else if (Code == "E3")
                {
                    Grade();
                }

                else if (Code == "E4")
                {
                    OddorEven();
                }

                else if (Code == "E5")
                {
                    NewPINNumberProgram();
                }
                else if (Code == "E6")
                {
                    PalindromeProgram();
                }
                else
                {
                    Console.WriteLine("Wrong Code, please try again");
                 
                }

                Console.WriteLine("\n\nDo you want to choose another Exercise Y/N ?");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }


                Console.Clear();
            } while (menu);



        }
        public static void ComparingIntegers()
        {
            Console.Clear();
            Console.WriteLine("-----------Exercise 1---------\n");

            Boolean menu = true;
            do
            {
                int integer1 = 0;
            int integer2 = 0;

            Console.Write("Please enter first number: ");
            integer1 = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            integer2 = Int32.Parse(Console.ReadLine());

            if (integer1 > integer2)
            {
                Console.WriteLine("\n{0} is larger then {1}.", integer1, integer2);
            }

            if (integer2 > integer1)
            {
                Console.WriteLine("\n{0} is larger then {1}.", integer2, integer1);
            }

            if (integer1 == integer2)
            {
                Console.WriteLine("\nThese numbers are equal.");
            }
                Console.WriteLine("\n\nDo you want try again: Y/N ?");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }


                Console.Clear();
            } while (menu);



        }
        public static void GuessMyNumber()
        {
            Console.Clear();
            Console.WriteLine("-------Exercise 2--------\n");

            Boolean menu = true;
            do
            {

                int myNum = 5;
            int userNum;
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess what it is???");
            userNum = int.Parse(Console.ReadLine());

            if (userNum == myNum)
            {
                Console.WriteLine("Yes - You guessed my number!!");
                    break;
            }
            else
            {
                if (userNum > myNum) Console.WriteLine("That number is too high, Try Again");
                else Console.WriteLine("That number is too low, Try Again");
            }
            
                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }


                Console.Clear();
            } while (menu);

        }
        public static void Grade()
        {
            Console.Clear();
            Console.WriteLine("-------Exercise 3-----------\n");

            

            Boolean menu = true;
            do
            { 

                int Mark;
            string Grade;

            Console.WriteLine("Please enter your Course Final Mark out of 100");
            Mark = int.Parse(Console.ReadLine());

            if (Mark >= 90 && Mark <=100) Grade = "A+";
            else if (Mark >= 80 && Mark <= 89) Grade = "A";
            else if (Mark >= 70 && Mark <= 79) Grade = "B+";
            else if (Mark >= 60 && Mark <= 69) Grade = "B";
            else if (Mark >= 50 && Mark <= 59) Grade = "C";
            else Grade = "F";

            Console.WriteLine("Your Grade is {0}", Grade);

             Console.WriteLine("\n\nDo you want to enter a differnt mark Y/N");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }

            } while (menu);

        }
        public static void OddorEven()
        {
            Console.Clear();
            Console.WriteLine("-------Exercise 4-----------\n");

            Boolean menu = true;
            do
            {

                int R, num;
            int i = 0;
            while (i == 0)
            {

                Console.Write("Please enter any number: ");
                num = int.Parse(Console.ReadLine());
                R = num % 2;
                if (R == 0)
                {
                    Console.WriteLine("That number is an even number\n");
                    break;
                }
                else Console.WriteLine("That number is an odd number");
                break;
            }
                Console.WriteLine("\n\nDo you want to enter a differnt number? Y/N");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }
                Console.Clear();
            } while (menu);

        }
        public static void NewPINNumberProgram()
        {
            Console.Clear();
            Console.WriteLine("-------Exercise 5-----------\n");

            Boolean menu = true;
            do
            {

             int pin = 0;
            int pin2 = 0;
            Console.Write("Please enter your 4-digit pin number:");
            pin = int.Parse(Console.ReadLine());

            if ((pin < 1000) || (pin > 9999))
            {
                Console.Write("That is not a valid 4-digit pin, press any key to exit program");
                
            }
            else 
            {
                Console.Write("Please re-enter your pin:");
                pin2 = int.Parse(Console.ReadLine());
                    if (pin == pin2)
                    {
                        Console.WriteLine("Your pin has been set");
                        break;
                    }

                    else Console.WriteLine("Error, your pin was not set! Please try again");
                    
                }
                

                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }


               
            } while (menu);
            
        }
        public static void PalindromeProgram()
        {
            Console.Clear();
            Console.WriteLine("-------Exercise 6-----------\n");
            Boolean menu = true;
            do
            { 
                string one, two, three;

                Console.WriteLine("Enter the first letter");
                one = Console.ReadLine();

                Console.WriteLine("Enter the second letter");
                two = Console.ReadLine();

                Console.WriteLine("Enter the third letter");
                three = Console.ReadLine();


                if ((two == "a") && (two == "e") && (two == "i") && (two == "o") && (two == "u"))
                {
                        Console.WriteLine("Well done, your word is a Palindrome!");
                    break;
                }
                else if ( (one == three))
                {
                    Console.WriteLine("Well done, your word is a Palindrome!");
                    break;
                }
                
                else
                {
                    Console.WriteLine("Error!!This word is NOT a Palindrome!, try again Y/N");
                }


                
            var check = Console.ReadLine().ToUpper();
            if (check == "N")

                { menu = false; }


                Console.Clear();
            } while (menu);

            
        }
        
    }
}
