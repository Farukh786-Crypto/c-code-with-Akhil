using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._09.Static.Interview_Question
{
    static class MyClass1
    {
        public static int x = 10;
        public static void Print()
        {
            
            x = x + 10;
            Console.WriteLine(x);
        }
    }
    /*class Program
    {
        *//*Output
            20
            30
            40
        *//*

        static void Main(string[] args)
        {
            // variable x copy created only one time and then share this value to all 

            MyClass1.Print();
            MyClass1.Print();
            MyClass1.Print();

            Console.ReadKey();
        }
    }*/
}
