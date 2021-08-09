using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._7.OOPS._7._3.Polymorphism._3.Method_Hiding
{
    class StudentHidingClass
    {
        // virtual shows the method is ready to override in child class
         
        public virtual void GetAllAdmission()
        {
            Console.WriteLine("This is parent class method !!!");
        }

        // it is not necessary to used virtual keyword when method hiding is used
        public void GetAllInfo()
        {
            Console.WriteLine("This is parent class Information !!!");
        }
    }
    class ItStudentoverriding1 : StudentHidingClass
    {
        
        // it is not necessary to use override keyword u use new keyword also .
      
        public new void GetAllAdmission()
        {
            Console.WriteLine("This is child class Method !!");
        }
        public new void GetAllInfo()
        {
            Console.WriteLine("This is child class information .");
        }
    }
   /* class MainClass
    {
    *//*    Output :
            This is parent class method !!!
            This is parent class Information !!!
            This is parent class method !!!
            This is parent class Information !!!
            This is child class Method !!
            This is child class information *//*
        static void Main(string[] args)
        {
            StudentHidingClass stud1 = new StudentHidingClass();
            stud1.GetAllAdmission();
            stud1.GetAllInfo();

            StudentHidingClass stud2 = new ItStudentoverriding1();
            stud2.GetAllAdmission();
            stud2.GetAllInfo();

            ItStudentoverriding1 stud3 = new ItStudentoverriding1();
            stud3.GetAllAdmission();
            stud3.GetAllInfo();

            Console.ReadKey();
        }
    }*/
}
