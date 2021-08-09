using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._14.String_and_StringBuilder
{
    class StringExampleClass1
    {
        public void Functionstring()
        {
            String str = "Hello";
            // string is immutable hence . it create new strings instance when we concate .

            str += "Farukh";
            str += "How are You?";

            Console.WriteLine(str);
            // StringBuilder is mutable hence we append value it plays with same instance 

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append("Farukh");
            sb.Append("How are You");

            Console.WriteLine(sb);
        }
    }
    /*class MainClass
    {
        static void Main(string[] args)
        {
            StringExampleClass1 str1 = new StringExampleClass1();
            str1.Functionstring();

            Console.ReadKey();
        }
    }*/
}
