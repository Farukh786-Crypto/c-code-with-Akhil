using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._12.Partial
{
    // both class having same name
    partial class PartialClass1
    {
        public string name { get; set; }

        // partial method is bydefault private 
        partial void Registration() // partial method 
        {
            Console.WriteLine("This is for Registration !!");
        }
        // partial method is bydefault private so use Display method to share to other classes 
        public void Display()
        {
            Registration();
        }
    }
    /*class Program
    {
        static void Main(string[] args)
        {
            PartialClass1 pc = new PartialClass1();
            pc.Display();

            Console.ReadKey();
        }
    }*/
}
