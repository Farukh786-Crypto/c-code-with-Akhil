using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._25._Covariance_and_Contravariance
{
    class Animal
    {

    }
    class Dog:Animal
    {

    }
    class Cat:Animal
    {

    }
   /* class CovarianceClass1
    {
        static void Main(string[] args)
        {
            // valid statement
            Animal obj1 = new Dog();
            obj1 = new Cat();

            // Group of animal points to the group of Dog class and Cat class before .NET 3.5 five error
            IEnumerable<Animal> obj2 = new List<Dog>();
            obj2 = new List<Cat>();

        }
    }*/
}
