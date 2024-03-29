﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._10.Interface
{
    interface IStudent
    {
        // no access modifier
        void Display(); // no need to use abstract keyword 
    }
    interface IITStudent
    {
        void Display();
    }
    class StudentClass : IStudent, IITStudent
    {
        public void Display() // no need to use override keyword
        {
            Console.WriteLine("IStudent Display method is called !!");
        }

        // Explicit interface is used .
        void IITStudent.Display()
        {
            Console.WriteLine("IITStudent Display method is called !!");
        }
    }
   /* class ExampleClass
    {
        static void Main(string[] args)
        {
            // interface reference  nut not be instantiated .
            IStudent student = new StudentClass();
            student.Display();

            IITStudent student1 = new StudentClass();
            student1.Display();

            Console.ReadKey();
        }
    }*/
}
