using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._25._Covariance_and_Contravariance
{
    delegate void Myptr<in T>(T o);  // use contravariance in keyword
    class Animal1
    {
        public bool Name { get; set; }
    }
    class Dog1 : Animal1
    {

    }
  /*  class ContravarianceClass2
    {
        static void Main(string[] args)
        {
            ContravarianceClass2 controbj = new ContravarianceClass2();
            Myptr<Animal1> o1 = controbj.process;

            Myptr<Dog1> odog = o1; // child delegate pass reference to parent delegates

        }
        void process(Animal1 obj)
        {
            Console.WriteLine(obj.Name);
        }

    }*/
}
