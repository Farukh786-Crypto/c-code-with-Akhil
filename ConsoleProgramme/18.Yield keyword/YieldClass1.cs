using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._18.Yield_keyword
{
    class YieldClass1
    {
       /* static void Main(string[] args)
        {
            foreach (var item in GetEvenNos(10))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }*/

        private static IEnumerable<object> GetEvenNos(int v)
        {
            for(int i = 0; i < v; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
