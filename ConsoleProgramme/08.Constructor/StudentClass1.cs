using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._8.Constructor
{
    class StudentClass1
    {
        public int Id { get; set; }
        private string _name;

        public string Name
        {
            get { return string.Concat("Mr/Mrs " + _name); }
            set { _name = value; }
        }
        public StudentClass1() // constructor same name as class name used to initialize variable 
        {
            Id = 1001;
            Name = "Farukh";
        }
        // note: constructor also overload i.e we can pass parameter to constructor 
        public void  Admission()
        {
            Console.WriteLine("This is Parent class Admission\n"+Id +"\n Name is :" +Name);
        }
    }
  /*  class MainClass
    {
        static void Main(string[] args)
        {
            StudentClass1 studentClass1 = new StudentClass1();
            studentClass1.Admission();
            Console.ReadKey();
        }
    }*/
}
