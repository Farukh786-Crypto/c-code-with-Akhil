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
            //somewhere = 1.1;   // gives error bcoz value is string already at compile time but we try to assign integer after build
            Console.WriteLine(somewhere);
        }

        public void DynamicFunction()
        {
            dynamic somewhere1 = "Akhil"; // value is checked at Runtime 
            somewhere1 = 1;  // it gives error at run time not compile time    
            Console.WriteLine(somewhere1);

        }

        // we cannot pass var as a parameter but assign dynamic as parameter
        public void Display(dynamic age)
        {

        }
    }
   /* class MainClass
    {
        static void Main(string[] args)
        {
            ProgrammeClass2 programmeClass2 = new ProgrammeClass2();
            programmeClass2.varFunction();
            Console.ReadKey();
        }
    }*/
}
