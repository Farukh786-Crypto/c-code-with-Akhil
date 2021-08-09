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
            
            if(o is string)
            {
                string name = (string)o;
                Console.WriteLine("My name is :"+name);
            }
        }
        public void ASkeyword()
        {
            string name = o as string;
            Console.WriteLine("My name is :" + name);
        }
    }
   /* class Program
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
