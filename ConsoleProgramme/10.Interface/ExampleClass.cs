using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._10.Interface
{
    interface IStudent
    {
        void Display();
    }
    interface IITStudent
    {
        void display();
    }
    class StudentClass : IStudent, IITStudent
    {
        // Explicit interface is used .
        void IStudent.Display()
        {
            Console.WriteLine("IStudent Display method is called !!");
        }

        void IITStudent.display()
        {
            Console.WriteLine("IITStudent Display method is called !!");
        }
    }
    /*class ExampleClass
    {
        static void Main(string[] args)
        {


            // interface reference pass nut not be instantiated .
            IStudent student = new StudentClass();
            student.Display();

            IITStudent student1 = new StudentClass();
            student1.display();

            Console.ReadKey();
        }
    }*/
}
