using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._20.Boxing_and_UnBoxing
{
    class BoxingUnBoxingClass1
    {
        public void BoxingFunc()
        {
            int a = 100;
            Console.WriteLine("Value type a is:{0}",a);
            object o = a; // value type to Reference type i.e Boxing
            Console.WriteLine("Reference type of a is:{0} called Boxing", o);

        }
        public void UnBoxingFunc()
        {
            object o1 = 100.23;
            double b = (double)o1;
        }
    }
   /* class Program
    {
        static void Main(string[] args)
        {
            BoxingUnBoxingClass1 obj = new BoxingUnBoxingClass1();
            obj.BoxingFunc();
            obj.UnBoxingFunc();

            Console.ReadKey();
        }
    }*/
}
