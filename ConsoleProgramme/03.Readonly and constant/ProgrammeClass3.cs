using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._3.Readonly_and_constant
{
    class ProgrammeClass3
    {
        // readonly and constant

        // constant : value must be declare at the time of initilization it cannot be changed throught the programme
        // constant value cannot be reinitilize
        public const string myconstvalue = "Akhil";

        // readonly : 
        public readonly int somereadonlyvar = 1;// if we dont assign value at intialization no error occur
        
        public ProgrammeClass3()
        {
            // reinitilize readonly variable inside constructor
            somereadonlyvar = 4;
            //myconstvalue = "Farukh"; // you can not change const variable value 
            Console.WriteLine(somereadonlyvar);
        }

    }
   /* class MainClass
    {
        static void Main(string[] args)
        {
            ProgrammeClass3 programmeClass3 = new ProgrammeClass3();
            Console.ReadKey();
        }
    }*/
}
