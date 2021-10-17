using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._15.Params_keyword
{
    class ParamskeywordClass1
    {
       /* static void Main(string[] args)
        {
            Console.WriteLine(calculate1(12, 12, 45));
            Console.WriteLine(calculate2(12, 12, 45, 46));

            // with params
            Console.WriteLine("with params " + calculate2(12, 12, 45, 46));

            Console.ReadKey();
        }*/
        // with params
        private static int calculate(params int[] params1)
        {
            int sum = 0;
            foreach (var item in params1)
            {
                sum += item;
            }
            return sum;
        }
        // without params
        private static int calculate1(int v1, int v2, int v3)
        {
            return v1 + v2 + v3;
        }
        // without params
        private static int calculate2(int v1, int v2, int v3, int v4)
        {
            return v1 + v2 + v3 + v4;
        }

    }
}
