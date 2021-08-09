using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._09.Static._1.Non_Static_class
{
    class NonStaticDemoClass1
    {
        // static variable
        public static string FirstName = String.Empty;
        
        // static constructor called only once
        static NonStaticDemoClass1()
        {
            Console.WriteLine(" Non static constructor ");
        }

        // non-static class constructor called when class object is created 
        public NonStaticDemoClass1()
        {
            Console.WriteLine(" static constructor ");
        }


        // static method
        public static void Display()
        {
            Console.WriteLine(" This is Student Display Method !! ");
        }

        // Non- static method
        public void Registration()
        {
            Console.WriteLine(" This is Registration method of Student class !! ");
        }
    }
   /* class Program
    {
        static void Main(string[] args)
        {
            // non static method acces using object of class
            NonStaticDemoClass1 demo1 = new NonStaticDemoClass1();
            demo1.Registration();

            NonStaticDemoClass1 demo2 = new NonStaticDemoClass1();
            demo1.Registration();

            // Access static method

            NonStaticDemoClass1.Display();

            Console.ReadKey();
        }
    }*/
}
