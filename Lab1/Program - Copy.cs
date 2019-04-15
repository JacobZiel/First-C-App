// Point 4 :- Import the namespace system
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Point 1 :- Namespace --> Class --> Method
//namespace Lab1
//{
//    class Program
//    {
//        // Point 2  :- Main means this is the first
//        // thing that will execute
//        static void Main(string[] args) // Point  :- In args we have patameters

//        {
//            Console.WriteLine("Enter how many records?");
//            int numrecord = Convert.ToInt16(Console.ReadLine());
//            for (int i = 0; i < numrecord; i++)
//            {
//                try
//                {
//                    string Name = "";
//                    int Age = 0;
//                    Console.WriteLine("Enter Name");
//                    Name = Console.ReadLine(); // Point 5 read lines takes data from key
//                    if (Name.Length == 0)
//                    {
//                        Console.WriteLine("Name is required");
//                        Console.Read();
//                        return;
//                    }
//                    Console.WriteLine("Enter Age");
//                    Age = Convert.ToInt16(Console.ReadLine());
//                    if (Age > 100)
//                    {
//                        Console.WriteLine("Age is not proper");
//                        Console.Read();
//                        return;
//                    }
//                    System.Console.WriteLine("Hello my name is " + Name + " and I'm " + Age + " years old");
//                    //Console.Read();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine("Please Try again ..invalid data");
//                }
//            }
//            Console.ReadLine();
        
//        }
//    }
    //class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Address { get; set; }
    //    public decimal Salary { get; set; }
    //    public bool Valid()
    //    {
    //        if(Name.Length==0)
    //        {
    //            return false; // below codes do not execute
    //        }
    //        if(Age > 100)
    //        {
    //            return false;
    //        }
    //        return true;

    //        }
    //}
//}
