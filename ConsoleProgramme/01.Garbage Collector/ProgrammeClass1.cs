using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._1.Garbage_Collector
{
    class ProgrammeClass1 : IDisposable
    {
        // constructor
        public ProgrammeClass1() // same name as a class
        {
            // initialization
        }

        // Destructor also called Finalize Method
        ~ProgrammeClass1()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            // write code to release unmanged resources
            GC.SuppressFinalize(this);
        }
    }
   /* class MainClass
    {
        static void Main(string[] args)
        {
            ProgrammeClass1 programmeClass1 = new ProgrammeClass1();
            GC.Collect(); // GC called explicitly
            Console.ReadKey();
        }
    }*/
}
