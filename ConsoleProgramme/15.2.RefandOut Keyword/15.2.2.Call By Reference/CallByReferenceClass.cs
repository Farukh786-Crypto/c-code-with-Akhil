using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._15._2.RefandOut_Keyword._15._2._2.Call_By_Reference
{
    class CallByReferenceClass
    {
       /* static void Main()
        {
            int outSideVar = 20;
            SomeFunction(ref outSideVar);// caller
            Console.WriteLine("outSideVar" + outSideVar); // Value is 30 value affected by outside using ref keyword
            Console.ReadKey();
        }*/

        private static void SomeFunction(ref int inSideVar)//callee
        {
            inSideVar = inSideVar + 10; // value is 30 inside method
            Console.WriteLine("InSideVar"+ inSideVar);
        }
    }
}
