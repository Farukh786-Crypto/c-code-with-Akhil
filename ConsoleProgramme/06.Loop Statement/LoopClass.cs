using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._6.Loop_Statement
{
    class LoopClass
    {
        public void ForloopFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
           
        }
        public void ForeachFunction()
        {
            List<string> list = new List<string> { "Akhil" , "Minesh" , "Farukh" , "Divya" };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void BreakandcontinueFunc()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i==5)
                {
                    continue;
                    //break;
                }

                Console.WriteLine(i);
                
            }
            Console.WriteLine("Loop completed !!");
        }
        public void whileLoop()
        {
            int i = 0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++; 
            }
        }
        public void dowhileLoop()
        {
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);
        }
    }
   /* class MainClass
    {
        static void Main(string[] args)
        {
            LoopClass loopClass = new LoopClass();
            loopClass.ForloopFunction();
            loopClass.ForeachFunction();
            loopClass.BreakandcontinueFunc();
            loopClass.dowhileLoop();
            Console.ReadKey();
        }
    }*/
}
