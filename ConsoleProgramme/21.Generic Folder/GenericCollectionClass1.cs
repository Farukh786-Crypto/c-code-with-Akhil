using System;
using System.Collections.Generic;
using System.Text;
// import system.collection
using System.Collections;

namespace ConsoleProgramme._21.Generic_Folder
{
    class GenericCollectionClass1
    {
        public void HashtableFunc()
        {
            Hashtable hs = new Hashtable();
            hs.Add("Name","Farukh");
            hs.Add(1, "Shaikh");

            foreach (var item in hs.Values)
            {
                Console.WriteLine(item);
            }
        }
        public void DictionaryFunc()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Name","Farukh");
            d.Add("Address","Pune");

            foreach (KeyValuePair<string,string> item in d)
            {
                Console.WriteLine("Name - {0} value {1}",item.Key,item.Value);
            }
        }
    }
    /*class MainClass
    {
        static void Main(string[] args)
        {

            GenericCollectionClass1 obj1 = new GenericCollectionClass1();
            obj1.HashFunc();

            Console.ReadKey();
        }
    }*/
}
