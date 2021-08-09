using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._24.Tuples_Folder
{
    class TupleClass1
    {
        static void Main(string[] args)
        {
            var tuple1 = Tuple.Create(1,23,6,34,56,"Farukh","Paul");
            Console.WriteLine(tuple1.Item1);

            var tuple2 = Tuple.Create(1,2,3,4,5,7,8,10);
            Console.WriteLine(tuple2.Rest);

            Tuple<int, int, string> tupple3 = Tuple.Create<int, int, string>(12,12,"Farukh");


            var tuple4 =Tuple.Create(1,2,3,4,5,6,7,Tuple.Create(12,34));
            Console.WriteLine(tuple4.Rest.Item1);

            Console.ReadKey();
        }
    }
}
