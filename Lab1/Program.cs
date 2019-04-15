// Point 4 :- Import the namespace system
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Point 1 :- Namespace --> Class --> Method
namespace Lab1
{
    class Program
    {
        // Point 2  :- Main means this is the first
        // thing that will execute
        static void Main(string[] args) // Point  :- In args we have patameters

        {
            Console.WriteLine("Enter how many records?");
            int numrecord = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < numrecord; i++)
            {
                try
                {
                    Person obj = new Person();
                    Console.WriteLine("Enter Name");
                    obj.Name = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    obj.Age = Convert.ToInt16(Console.ReadLine());
                    if(obj.Valid())
                    {
                        Console.WriteLine("name " + obj.Name + " Age " + obj.Age);
                    }
                    else
                    {
                        Console.WriteLine("Please Try again ..invalid data");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Try again ..invalid data");
                }
            }
            Console.ReadLine();
        
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public bool Valid()
        {
            if(Name.Length==0)
            {
                return false; // below codes do not execute
            }
            if(Age > 100)
            {
                return false;
            }
            return true;

            }
    }
}
