using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._7.OOPS._7._2.Inheritence._2.Multilevel_Inheritence
{
    class MultilevelClass
    {
        public int Id { get; set; }
        private string _name;

        public string Name
        {
            get { return string.Concat("Mr/Mrs" + _name); }
            set { _name = value; }
        }

        public void GetAdmission()
        {
            Console.WriteLine("This is Parent class for admission");
        }
    }
    class ITStudent1 : MultilevelClass
    {
        public void Display()
        {
            base.GetAdmission();
            Console.WriteLine("This is child method IT Student Display !!");
        }
    }
    class HardwareStudent : ITStudent1
    {
        public void GetAdmissionForHardwareCCNA()
        {
            Console.WriteLine("Admission taken for CCNA !!");
        }
    }
   /*class MainClass
   {
       static void Main(string[] args)
       {
           HardwareStudent hardwareStudent = new HardwareStudent();
            hardwareStudent.GetAdmissionForHardwareCCNA();
            hardwareStudent.Display();
            hardwareStudent.GetAdmission();
           Console.ReadKey();
       }
   }*/
}
