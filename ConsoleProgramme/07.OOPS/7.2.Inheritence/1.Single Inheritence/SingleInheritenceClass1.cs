using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._7.OOPS._7._2.Inheritence._1.Single_Inheritence
{
    class SingleInheritenceClass1
    {
        public int Id { get; set; }
        private string _name;

        public string Name
        {
            get { return string.Concat("Mr/Mrs"+_name); }
            set { _name = value; }
        }

        public void GetAdmission()
        {
            Console.WriteLine("This is Parent class for admission");
        }
    }
    class ITStudent: SingleInheritenceClass1
    {
        public void Display()
        {
            base.GetAdmission();// called parent class method
            Console.WriteLine("This is child method IT Student Display !!");
        }
    }
   /* class MainClass
    {
        static void Main(string[] args)
        {
            ITStudent iTStudent = new ITStudent();
            iTStudent.Display();
            Console.ReadKey();
        }
    }*/
}
