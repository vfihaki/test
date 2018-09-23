using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented__Programming
{
    class Car
    {
        private string cmake;
        private string cmodel;
        private string ccolour;
        private string crego;
        
        public string Cmake { get { return cmake; } set { cmake = value; } }
        public string Cmodel { get { return cmodel; } set { cmodel = value; } }
        public string Ccolour { get { return ccolour; } set { ccolour = value; } } 
        public string Crego { get { return crego; } set { crego = value; } }
        public string GetFullDetail()
        {
            return "\nCar Make: " + Cmake + "\nCar Model: " + Cmodel + "\nCar Colour: " + Ccolour + "\nCar Rego: " +  Crego + "\n";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Cmake = "Ford";
            c1.Cmodel = "Falcon";
            c1.Ccolour = "Black";
            c1.Crego = "PH4890X";
            Console.WriteLine($"Car 1: {c1.GetFullDetail()}");

            Car c2 = new Car();
            c2.Cmake = "Holden";
            c2.Cmodel = "HSV E Series";
            c2.Ccolour = "Red";
            c2.Crego = "YY678KJ";
            Console.WriteLine($"Car 2: {c2.GetFullDetail()}");

            Car c3 = new Car();
            c3.Cmake = "Toyota";
            c3.Cmodel = "Hilux";
            c3.Ccolour = "Blue";
            c3.Crego = "FF569YI";
            Console.WriteLine($"Car 3: {c3.GetFullDetail()}");

            Car c4 = new Car();
            c4.Cmake = "Mazda";
            c4.Cmodel = "Mazda-6";
            c4.Ccolour = "White";
            c4.Crego = "LO5836TR";
            Console.WriteLine($"Car 4: {c4.GetFullDetail()}");

            Car c5 = new Car();
            c5.Cmake = "Suzuki";
            c5.Cmodel = "Swift";
            c5.Ccolour = "Silver";
            c5.Crego = "PQ587UY";
            Console.WriteLine($"Car 5: {c5.GetFullDetail()}");

            Car[] collection = new Car[5];
            collection[0] = c1;
            collection[1] = c2;
            collection[2] = c3;
            collection[3] = c4;
            collection[4] = c5;
            for(int i = 0; i < collection.Length; i++)
            {
                Console.WriteLine($"Car {i + 1}: \nCar Make: {collection[i].Cmake}\nCar Model: {collection[i].Cmodel}\nCar Colour: {collection[i].Ccolour}\nCar rego: {collection[i].Crego}\n\n");
            }
        }
    }
}
