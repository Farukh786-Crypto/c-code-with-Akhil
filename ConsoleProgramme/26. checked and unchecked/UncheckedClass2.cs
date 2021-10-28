using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._26._checked_and_unchecked
{
    class UncheckedClass2
    {
        static void Main(string[] args)
        {
            const int a = 2147483647;
            const int b = 2147483647;

            //int c = a + b; // gives error at compiled time bcoz of const so to bypass unchecked is used
            //Console.WriteLine("Addition is :" + c);  

            int d = unchecked(a + b);  // gives overflow Exceptions
        }
    }
}
