using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._15._2.RefandOut_Keyword._15._2._3.Call_By_Out
{
    class CallByOut
    {
      /*  static void Main()
        {
            int outSideVar = 20;
            SomeFunction(out outSideVar); // caller
            Console.WriteLine(outSideVar); // Value is 10 value affected by outside using ref keyword
            Console.ReadKey();
        }*/

        private static void SomeFunction(out int inSideVar) // callee does not take any caller value
        {
            inSideVar = 0; // value must be initialized intialized
            inSideVar = inSideVar + 10; // value is 10 inside method
        }
    }
}
