using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._21.Generic_Folder
{
    class WithGenericsClass  // nexted class Shows one class contain another class
    {
        class Check1<unknownDatatype> // create own datatype
        {
            public bool Compare(unknownDatatype a1, unknownDatatype b1)
            {
                if (a1.Equals(b1))
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
                // Datatype is add at runtime
                Check1<int> c1 = new Check1<int>();
                Console.WriteLine("Two Value is Match or not?:" + c1.Compare(1, 3));

                Check1<string> str1 = new Check1<string>();
                Console.WriteLine("Two Value is Match or not?:" + str1.Compare("Farukh", "Farukh"));
                Console.ReadKey();
            }
        }*/
    }
}
