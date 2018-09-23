using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_exercise
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
                Console.WriteLine("You may choose from the following Switch Practice Exercises below\n");
                Console.WriteLine("Exercise 1:" + " CODE: E1");
                Console.WriteLine("Exercise 2:" + " CODE: E2");
                Console.WriteLine("Exercise 3:" + " CODE: E3");
                Console.Write("\nPlease enter the CODE:");
                Code = Console.ReadLine().ToUpper();

                if (Code == "E1")
                {
                    favPet();
                }

                else if (Code == "E2")
                {
                    fruitStoll();
                }
                else if (Code == "E3")
                {
                    Calculator();
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
        public static void favPet()
        {
            Boolean menu = true;
            do
            {
                Console.WriteLine("Please enter a pet");
                string favpet = "dogs";
                string userpick = "";

                userpick = Console.ReadLine();

                switch (userpick)
                {
                    case "dogs":
                        Console.WriteLine("{0}, Yes you guess it right", favpet);
                        break;
                    case "rabbits":
                        Console.WriteLine("{0}, good try, try again", userpick);
                        break;
                    case "chickens":
                        Console.WriteLine(" {0}, good try, try again", userpick);
                        break;
                    case "parrots":
                        Console.WriteLine("{0}, good try, try again", userpick);
                        break;

                    default:
                        Console.WriteLine("Error!! not a pet, try again");
                        break;

                }

                Console.WriteLine("\n\nDo you want to try again? Y/N");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }



                Console.Clear();
            } while (menu);
        }
        public static void fruitStoll()
        {
                Boolean menu = true;
                do
                {
                    Console.WriteLine("\t Purchasing Fruit System\n");
                    Console.WriteLine("Select Fruit");
                    Console.WriteLine("Apples ");
                    Console.WriteLine("Bananas ");
                    Console.WriteLine("Kiwifruits ");
                    Console.WriteLine("Oranges ");
                    Console.Write("Enter Your Selection: ");
                    string menuSelection = "";
                    double totalPrice = double.MinValue;
                    menuSelection = Console.ReadLine();

                    switch (menuSelection)
                    {
                        case "Apples":
                            totalPrice = 1.25;
                            Console.WriteLine("Apples ${0} per kg", totalPrice);
                            break;
                        case "Bananas":
                            totalPrice = 3.15;
                            Console.WriteLine("Bananas ${0} per kg", totalPrice);
                            break;
                        case "Kiwifruits":
                            totalPrice = 4.65;
                            Console.WriteLine("Kiwifruits ${0} per kg", totalPrice);
                            break;
                        case "Oranges":
                            totalPrice = 2.75;
                            Console.WriteLine("Oranges ${0} per kg", totalPrice);
                            break;
                        default:
                            Console.WriteLine("Invalid Selection !");
                            break;

                    }
                        Console.WriteLine("\n\nDo you want to try again? Y/N");

                        var check = Console.ReadLine().ToUpper();
                        if (check == "N")

                        { menu = false; }



                        Console.Clear();
                    } while (menu);
                }
        public static void Calculator()
        {
            Boolean menu = true;
            do
            {

                int a, b;
                string choice;
                float result;

                Console.WriteLine("enter 1st number= ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("+ Addition ");
                Console.WriteLine("- Subtraction ");
                Console.WriteLine("x Multiplication ");
                Console.WriteLine("/ Division ");
                choice = Console.ReadLine();

                Console.WriteLine("enter 2nd number= ");
                b = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case "+":
                        result = a + b;
                        Console.WriteLine("{0} + {1} = {2}", a, b, result);
                        break;
                    case "-":
                        result = a - b;
                        Console.WriteLine("{0} - {1} = {2}", a, b, result);
                        break;
                    case "*":
                        result = a * b;
                        Console.WriteLine("{0} x {1} = {2}", a, b, result);
                        break;
                    case "/":
                        result = a / b;
                        Console.WriteLine("{0} / {1} = {2}", a, b, result);
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
                Console.WriteLine("\n\nDo you want to try again? Y/N ");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")

                { menu = false; }



                Console.Clear();
            } while (menu);
        }   
    }

}
