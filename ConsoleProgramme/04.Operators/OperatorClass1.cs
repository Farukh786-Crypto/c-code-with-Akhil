using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._4.Operators
{
    class OperatorClass1
    {
        // Assignment Operator
        int FirstNo = 101;
        int SecondNo = 101;
        int ThirdNo = 1001;

       

        // Arithmetic Operator like +,-,*,/,%
        public void ArithmeticFunce()
        {
            Console.WriteLine(FirstNo % SecondNo);
        }

        // Comparison Operator like == , != , > ,>= , < , <=

        public void ComparisonFunc()
        {
            if(FirstNo<=SecondNo)
            {
                Console.WriteLine("Both Number are not Equal");
            }
        }

        // Conditional Operator like && , || 

        public void ConditionalFunc()
        {
            if((FirstNo==SecondNo) && (FirstNo==ThirdNo))
            {
                Console.WriteLine("All Value Are Same !!");
            }
        }

        // without Ternary Operator

        public void withoutTernaryFunc()
        {
            string Result1 = String.Empty;

            if (FirstNo == SecondNo)
            {
                Result1 = "Equal";
            }
            else
                Result1 = "Not Equal";
        }

        // with Ternary Operator
        public void withTernaryFunc()
        {
            string result = String.Empty;
            result = (FirstNo == SecondNo) ? "Equal" : "Not Equal";
        }
       

    }
   /* class MainClass
    {
        static void Main(string[] args)
        {

        }
    }*/
}
