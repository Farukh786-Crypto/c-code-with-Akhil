﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleProgramme._19.Exception_Folder._1.Examples
{
    class ExceptionClass1
    {
        public void ExceptionFunc()
        {
          
            try
            {
                StreamReader sr = new StreamReader(@"E:\Programme\c#\ConsoleProgramme\ConsoleProgramme\19.Exception\Hello1.txt");
                Console.WriteLine(sr.ReadToEnd());

            }
            // Note: if u want to write user defined exception then write above Catch(Exception ex) not after below method
            // o.w it is not run bcoz All type of exception class is Handled by Catch(Exception ex) method
            catch (FileNotFoundException ex) 
            {
                Console.WriteLine("File does not exist !!" + ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Some Generic Exception occured !!");
                Console.WriteLine("File does not exist !!" + ex.StackTrace);
            }
            finally
            {
               
                Console.WriteLine(" File Closed !! ");
            }
        }
    }
  /*  class Mainclass
    {
        static void Main(string[] args)
        {
            ExceptionClass1 exceptionobj = new ExceptionClass1();
            exceptionobj.ExceptionFunc();

            Console.ReadKey();
        }
    }*/
}
