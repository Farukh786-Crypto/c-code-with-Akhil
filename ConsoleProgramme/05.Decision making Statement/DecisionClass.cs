using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._5.Decision_making_Statement
{
    class DecisionClass
    {
        // Decision Making Satement
        // if else statement

        public void ifelseFunc()
        {
            Console.WriteLine("Enter Your Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age<0)
            {
                Console.WriteLine("Invalid Age Entered !!");
            }
            else if(age>0 && age<18)
            {
                Console.WriteLine("Valid Age but not Eligible for vote !");
            }
            else if(age>18)
            {
                Console.WriteLine("Eligible for Vote !!");
            }
        }

        // switch case statement
        public void SwitchFunc()
        {
            Console.WriteLine("Enter Your Age ");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (age)
            {
                case 18:
                    Console.WriteLine("You are Eligible for Company !!");
                    break;

                case 60:
                    Console.WriteLine("Congrats !! You are Retire from work Now !!");
                    break;
                default:
                    Console.WriteLine("Invalid !!!");
                    break;
            }
        }
    }
   /* class MainClass
    {
        static void Main(string[] args)
        {

        }
    }*/
}
