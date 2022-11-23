using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._22._Delegates_Folder._1._Delegates_Examples
{
    // step 1: initialize delegates
    // note same return type as like functions of following class and same number of parameter
    public delegate void MyDelegate(string name);
    // The keyword static has no meaning for the delegate definition, just like enum or const definitions.
    class DelegateClass1
    {
      /*static void Main(string[] args)
        {
            // step 2: create object of delegates and just past function name only
            MyDelegate myDelegate = Display;
            myDelegate += ShowEmployee;
            myDelegate += AdmittedEmployees;


            // step 3 : invoked method
            myDelegate.Invoke("Farukh");

            // step 4 : if u dont want to invoked method then used following code

            foreach (MyDelegate item in myDelegate.GetInvocationList())
            {
                Console.WriteLine("Farukh Shaikh !!");
            }

            Console.ReadKey();
        }*/

        private static void ShowEmployee(string name)
        {
            Console.WriteLine(" This is Show Employees " + name);
        }

        private static void AdmittedEmployees(string name)
        {
            Console.WriteLine(" This is AdmittedEmployees " + name);
        }

        private static void Display(string name)
        {
            Console.WriteLine(" This is display Function !! " + name);
        }
    }
}
