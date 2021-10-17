using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._09.Static.Interview_Question
{
    class MyClass2
    {
        public  int x = 10;
        public void Print()
        {

            x = x + 10;
            Console.WriteLine(x);
        }
    }
    /*class Program
    {
       *//* Output
            20
            30
            20
            30*//*
        

        static void Main(string[] args)
        {
            // m1 have different memory contain value of x
            MyClass2 m1 = new MyClass2();
            m1.Print();
            m1.Print();

            // m2 have different memory contain value of x
            MyClass2 m2 = new MyClass2();
            m2.Print();
            m2.Print();

            Console.ReadKey();
        }
    }*/
}
