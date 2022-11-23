using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._13.IS_and_AS_keyword
{
    class ISASKeywordClass1
    {
        object o = "Farukh";
        public void ISkeyword()
        {
            
            if(o is string)// step 1: check object is string or not i.e check compactibility of object
            {
                string name = (string)o;// step 2 : then convert into string i.e convert into its datatypes
                Console.WriteLine("My name is :"+name);
            }
        }
        public void ASkeyword()
        {
            string name = o as string; // both 2 steps of is method is done by as in one line
            Console.WriteLine("My name is :" + name);
        }
    }
  /*  class Program
    {
        static void Main(string[] args)
        {
            ISASKeywordClass1 obj1 = new ISASKeywordClass1();
            obj1.ISkeyword();
            obj1.ASkeyword();

            Console.ReadKey();
        }
    }*/
}
