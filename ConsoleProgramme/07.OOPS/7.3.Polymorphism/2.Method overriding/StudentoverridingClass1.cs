using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._7.OOPS._7._3.Polymorphism._2.Method_overriding
{
    class StudentoverridingClass1
    {
        // virtual shows the method is ready to override in child class
        public virtual void GetAllAdmission()
        {
            Console.WriteLine("This is parent class method !!!");
        }
    }
    class ItStudentoverriding1: StudentoverridingClass1
    {
        // override shows method is override inside child class
        // it is not necessary to use override keyword u use new keyword also .
        public override void GetAllAdmission()
        {
            Console.WriteLine("This is child class method !!!");
        }
        
    }
   /* class MainClass
    {
        // In method overriding always check whose object is created with new keyword check RHS only
        // see output and below code  
       *//* Output
            This is parent class method !!!
            This is child class method !!!
            This is child class method !!!*//*

        static void Main(string[] args)
        {
            StudentoverridingClass1 student = new StudentoverridingClass1();
            student.GetAllAdmission();

            StudentoverridingClass1 student1 = new ItStudentoverriding1();
            student1.GetAllAdmission();

            ItStudentoverriding1 itstudent = new ItStudentoverriding1();
            itstudent.GetAllAdmission();

            Console.ReadKey();
        }
    }*/
}
