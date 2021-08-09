using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._2.Var_and_Dynamic
{
    class ProgrammeClass2
    {
        // var and Dynamic

        // You cannot Assign var value as global level but we assign dynamic 
        dynamic name = "Vishal";
        public void varFunction()
        {
            var somewhere = "Farukh"; // Assign value datatype at compile time as string
            // somewhere = 1.1;   // gives error bcoz value is string already at compile time but we try to assign integer
        }

        public void DynamicFunction()
        {
            dynamic somewhere1 = "Akhil"; // value is checked at Runtime 
           // somewhere1 = 1.1;       // error occur at runtime

        }

        // we cannot pass var as a parameter but assign dynamic as parameter
        public void Display(dynamic age)
        {

        }
    }
    /*class MainClass
    {
        static void Main(string[] args)
        {

        }
    }*/
}
