using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._3.Readonly_and_constant
{
    class ProgrammeClass3
    {
        // readonly and constant

        // constant : value must be declare at the time of initilization it cannot be changed
        // constant value cannot be reinitilize
        public const string myconstvalue = "Akhil";

        // readonly : 
        public readonly int somereadonlyvar = 1;// if we dont assign value at intialization no error occur
        public ProgrammeClass3()
        {
            // reinitilize variable inside constructor
            somereadonlyvar = 4;
        }

    }
   /* class MainClass
    {
        static void Main(string[] args)
        {

        }
    }*/
}
