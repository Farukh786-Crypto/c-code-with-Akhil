using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._12._2.Extension_Method
{
    static class ExtensionClass
    {
        public static int WordCount(this String obj) //  where String is class
        {
            string[] myname = obj.Split(' ');
            return myname.Length;
        }
    }
  /*  class Program
    {
        static void Main()
        {
            string name = "Farukh Shaikh";
            Console.WriteLine("Word Length of String :" + name.WordCount());
            Console.ReadKey();
        }
    }*/
}
