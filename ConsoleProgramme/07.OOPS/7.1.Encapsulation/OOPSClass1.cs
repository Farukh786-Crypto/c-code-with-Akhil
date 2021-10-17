using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._7.OOPS._7._1.Encapsulation
{
    class Student
    {
        public int StudId { get; set; }
        private string _name;

        public string Name
        {
            get { return string.Concat("Mr/Mrs "+_name); }
            set { _name = value; }
        }
    }
   /* class MainClass
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.StudId = 1;
            s1.Name = "Farukh";
            Console.WriteLine("Student Id is :" + s1.StudId + "\nStudent Name is :" + s1.Name);
            Console.ReadKey();
        }
    }*/
}
