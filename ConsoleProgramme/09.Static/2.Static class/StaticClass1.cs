using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._09.Static._2.Static_class
{
    // static class
    static class StaticClass1
    {
        public static string FirstName = string.Empty;

        //static constructor called only once by CLR
        // cannot contain parameter and access modifier
        static StaticClass1()// static constructor is parameterless and not access modifier
        {
            Console.WriteLine(" Static constructor is called !! ");
        }
        public static void Display()
        {
            Console.WriteLine("This is static method !!");
        }
    }
    /*class Program
    {
        static void Main(string[] args)
        {
            StaticClass1.FirstName = "Farukh";
            Console.WriteLine("First Name is {0}", StaticClass1.FirstName);

            StaticClass1.Display();

            Console.ReadKey();
        }
    }*/
}
