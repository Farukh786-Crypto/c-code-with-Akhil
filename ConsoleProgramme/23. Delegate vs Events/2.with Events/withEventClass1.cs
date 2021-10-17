using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramme._23._Delegate_vs_Events._2.with_Events
{
    public delegate void MyDelegate(string name);
    class CustomEventDemo
    {
        // initialize event by passing delegate name
        public event MyDelegate EventRaise;

        public void TriggerEvent()
        {
            Console.WriteLine(" Event trigger by user !! ");
            EventRaise?.Invoke("Farukh");
        }
    }
    class withEventClass1
    {
       /* static void Main(string[] args)
        {
            CustomEventDemo customEventDemo = new CustomEventDemo();
            customEventDemo.EventRaise += EventRaisedByUser;
            customEventDemo.TriggerEvent();

            // customEventDemo.EventRaise = null;   .. gives error at compile time

            Console.ReadKey();
        }
*/
        private static void EventRaisedByUser(string name)
        {
            Console.WriteLine(" Process completed by : " + name);
        }
    }

}
