using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._11.Abstract
{
    // abstract class shows with abstract keyword
    abstract class StudentClass
    {
        // Abstract class contain constructor but class doesnt instantiated
        public StudentClass()
        {
            Console.WriteLine("Abstract class constructor is called ");
        }
        // non abstract method / concrete method 
        public void Display()
        {
            Console.WriteLine("This is Concrete method in Student Abstract class");
        }

        // abstract method it is half defined method which must be implemented inside child class
        public abstract void Registration();// must be implemented in child class
    }
    class ItStudent : StudentClass
    {
        public override void Registration() // override keyword is used
        {
            Console.WriteLine("This method is for Registration");
        }
    }
   /* class Program
    {
        //output
       //Abstract class constructor is called
        //This is Concrete method in Student Abstract class
        //This method is for Registration

        static void Main(string[] args)
        {
            StudentClass stud = new ItStudent();
            stud.Display();
            stud.Registration();

            Console.ReadKey();
        }
    }*/
}
