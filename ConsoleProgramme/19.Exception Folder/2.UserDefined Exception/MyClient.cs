using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._19.Exception_Folder._2.UserDefined_Exception
{
    class MyException : Exception // Exception is class which is inherited
    {
        public MyException(string str)
        {
            Console.WriteLine("User Defined Exceptions !!");
        }
    }
    class MyClient
    {
       /* public static void Main()
        {
            try
            {
                throw new MyException("Custom");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught here :" + ex.ToString());
            }
            Console.WriteLine("Last Statement !!");
        }*/
    }
}
