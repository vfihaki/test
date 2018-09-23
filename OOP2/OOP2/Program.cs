using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Person
    {
        public string fname;
        public string lname;
        private int age;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }
        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }
        public string GetFullDetail()
        {
            return $"First Name: {Fname}\nLast Name: {Lname}\nAge: {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Viliami", "Fihaki", 40);
            Console.WriteLine(p1.GetFullDetail());
            Console.ReadLine();
          
        }
    }
}
