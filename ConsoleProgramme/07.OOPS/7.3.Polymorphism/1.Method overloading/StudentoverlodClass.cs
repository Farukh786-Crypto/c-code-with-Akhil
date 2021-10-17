using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._7.OOPS._7._3.Polymorphism._1.Method_overloading
{
    class StudentoverlodClass
    {
        // without parameter
        public void GetAdmission()
        {
            Console.WriteLine("Get All Admission !!");
        }
        //with parameter
        public void GetAdmission(int studentId)
        {
            Console.WriteLine("Get admission based on Student Id :"+studentId);
        }
        // Error return type doesnt matter if parameter and its datatype are same
        /*  public int GetAdmission(int studentId)
          {
              return studentId;
          }*/
        // same function with different datatype of parameter
        public void GetAdmission(double studentId)
        {
            Console.WriteLine("Get admission based on Student Id :" + studentId);
        }

        // with extra parameter
        public void GetAdmission(int studentId,string name)
        {
            Console.WriteLine("Get Admission based on Student Id :"+ studentId +"Student Name :"+ name);
        }
        // change order od parameter
        public void GetAdmission(string name, int studentId)
        {
            Console.WriteLine("Get Admission based on Student Id :" + studentId + "Student Name :" + name);
        }
    }
   /* class MainClass
    {
        static void Main(string[] args)
        {
            StudentoverlodClass studentoverlodClass = new StudentoverlodClass();
            studentoverlodClass.GetAdmission();
            studentoverlodClass.GetAdmission(1);
            studentoverlodClass.GetAdmission(2, "Farukh");
            studentoverlodClass.GetAdmission("Akshay", 3);

            Console.ReadKey();
        }
    }*/
}
