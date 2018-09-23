using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
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
                Console.WriteLine("Question 1:" + " CODE: Q1");
                Console.WriteLine("Question 2:" + " CODE: Q2");
                Console.WriteLine("Question 3:" + " CODE: Q3");
                Console.WriteLine("Question 4:" + " CODE: Q4");
                Console.Write("\nPlease enter the CODE:");
                Code = Console.ReadLine().ToUpper();

                if (Code == "Q1")
                {
                    question1();
                }

                else if (Code == "Q2")
                {
                    question2();
                }
                else if (Code == "Q3")
                {
                    question3();
                }
                else if (Code == "Q4")
                {
                    question4();
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
        public static void question1()
        {

        

            Console.WriteLine("*******************************************");
            Console.WriteLine("***Welcome to the CrankWorx Medal Awards***");
            Console.WriteLine("*******************************************");

            string[] metalWinnwer = new string[3];

            Console.WriteLine("Enter the name of the GOLD medal winner: ");
            metalWinnwer[0] = Console.ReadLine();
            Console.WriteLine("Enter the name of the SILVER medal winner: ");
            metalWinnwer[1] = Console.ReadLine();
            Console.WriteLine("Enter the name of the BRONZE medal winner: ");
            metalWinnwer[2] = Console.ReadLine();

            Console.WriteLine("Which Metal winner would you like to know");
            Console.WriteLine("Press 1 for the gold metal winner,");
            Console.WriteLine("Press 1 for the silver metal winner,");
            Console.WriteLine("Press 1 for the bronze metal winner,");
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Gold metal went to: {1}", metalWinnwer[input -1]);
            }
            else if(input == 2)
            {
                Console.WriteLine("Silver metal went to: {1}", metalWinnwer[input -1]);
            }
            else if(input == 3)
            {
                Console.WriteLine("Bronze mtral went to: {1}", metalWinnwer[input -1]);
            }
            Console.ReadLine();
        }
        public static void question2()
        {

            string[] name = new string[5];
            for (int i = 1; i < name.Length; i++)
            {
                Console.WriteLine("Please enter name {0}: ", (i + 1));
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("The first name entered is {0}", (name[0]));
            Console.WriteLine("The first name entered is {0}", (name[4]));

            Console.ReadLine();
        }
        public static void question3()
        {

            string[] ticket = new string[20];
            for (int i = 0; i < ticket.Length; i++)
            {
                Console.Write("Ticket {0}: ", i);
                ticket[i] = Console.ReadLine();
            }
            string[] name = ticket;
            Random rand = new Random();
            int winner = rand.Next(0, 19);
            Console.WriteLine("The winner is {0}", (name[winner]));
            winner = rand.Next(0, 19);

            Console.ReadLine();
        }
        public static void question4()
        {
            string[] greetings = { "Hello", "Kia ora", "Kon'nichiwa", "Namaste", "Bonjour", "Talofa" };
            Console.WriteLine("I can translate 'hello' in 5 different langauges:");
            Console.WriteLine("1. Maori");
            Console.WriteLine("2. Japanese");
            Console.WriteLine("3. Hindi");
            Console.WriteLine("4. French");
            Console.WriteLine("5. Samoan");

            Console.WriteLine("Which langauge translation do you wish to see (1 - 5) ");
            int selection = int.Parse(Console.ReadLine()) -1;
            switch(selection)
            {
                case 1:
                    Console.WriteLine(greetings[selection]);
                    break;
                case 2:
                    Console.WriteLine(greetings[selection]);
                    break;
                case 3:
                    Console.WriteLine(greetings[selection]);
                    break;
                case 4:
                    Console.WriteLine(greetings[selection]);
                    break;
                case 5:
                    Console.WriteLine(greetings[selection]);
                    break;
                default:
                    Console.WriteLine("ooops, something when wrong");
                    break;
                  

            }
            Console.ReadLine();
        }
        public static void externexeQ1()
        {
            int[] num = new int[5];
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Please enter number {0}:", (i + 1));
                num[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Forward");
            for (int j = 0; j < num.Length; j++)
            {
                Console.WriteLine("Number {0}: {1}",(j + 1), (num[j]) )
            }
        }

        
    }
}
