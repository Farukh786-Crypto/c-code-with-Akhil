using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._22._Delegates_Folder._2._Inbuilt_delegates_example
{
    public delegate void MyDelegate(string name);
   /* class InbuiltDelegateClass2
    {
        static void Main(string[] args)
        {
            // Action : void
            Action mydel = Display;
            mydel.Invoke();

            // Predicate : bool
            Predicate<string> mypred = CheckStringNullOrNot;
            Console.WriteLine(mypred.Invoke("Farukh"));


            // Func : input type , output type
            Func<int, int, string> myfun = Calculate;
            Console.WriteLine(myfun.Invoke(12,56));

            Console.ReadKey();
        }

        private static string Calculate(int arg1, int arg2)
        {
            return (arg1 + arg2).ToString();
        }

        private static bool CheckStringNullOrNot(string obj)
        {
            return string.IsNullOrEmpty(obj);
        }

        private static void Display()
        {
            Console.WriteLine(" This is Action delegate method !! ");
        }
    }*/
}
