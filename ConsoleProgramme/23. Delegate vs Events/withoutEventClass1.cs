using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._23._Delegate_vs_Events
{
    public delegate void MyDelegate1(string name);
   /* class WithoutEventClass1
    {
        static void Main(string[] args)
        {
            MyDelegate1 mydel1 = Display;
            mydel1 += showEmployees;
            
            // mydel1 =null     .. Error occured inside delegates

            mydel1.Invoke("Farukh");

            Console.ReadKey();
        }

        private static void showEmployees(string name)
        {
            Console.WriteLine(" This is showEmployees Method !! ");
        }

        private static void Display(string name)
        {
            Console.WriteLine(" This is display method !! ");
            throw new Exception("Some error occured !! ");
        }
    }*/
}
