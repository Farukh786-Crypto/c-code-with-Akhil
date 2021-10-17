using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._21.Generic_Folder
{
    class Check
    {
        public bool Compare(int a1,int b1)
        {
            if(a1==b1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    /*class MainClass
    {
        static void Main(string[] args)
        {
            Check c1 = new Check();
            Console.WriteLine("Two Value is Match or not?:"+c1.Compare(1, 3));
            Console.ReadKey();
        }
    }*/
}
