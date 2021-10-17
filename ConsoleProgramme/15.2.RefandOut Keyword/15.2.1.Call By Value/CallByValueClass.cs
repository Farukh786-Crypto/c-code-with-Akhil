using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._15._2.RefandOut_Keyword._15._2._1.Call_By_Value
{
    class CallByValueClass
    {
       /* static void Main()
        {
            int outSideVar = 20;
            SomeFunction(outSideVar);// caller
            Console.WriteLine("OutSideVar :"+outSideVar); // Value is 20 value not affected by outside
            Console.ReadKey();
        }*/

        private static void SomeFunction(int inSideVar) //callee
        {
            inSideVar = inSideVar + 10; // value is 30 inside method
            Console.WriteLine("InsideVar :"+inSideVar);
        }
    }
}
