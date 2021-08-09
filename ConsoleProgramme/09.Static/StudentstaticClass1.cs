using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._9.Static
{
    static class StudentstaticClass1
    {
        static StudentstaticClass1()
        {
            Console.WriteLine("Static constructor is called !!");
        }
        public static void GetAdmission()
        {
            Console.WriteLine("This is parent class for Admission Id");
        }
    }
    
    // static class cannot be inherited . static class can not be parent or child .
    /*  class MyClass : StudentstaticClass
      {

      }*/
    /*class MainClass
    {
        static void Main(string[] args)
        {
            // we cannot create object of static class .
            //StudentstaticClass1 studentstaticClass1 = new StudentstaticClass1();

            // we can acess the static member by using classname .
            // when first time member called static constructor is called 

            StudentstaticClass1.GetAdmission();
            Console.ReadKey();
        }
    }*/
}
