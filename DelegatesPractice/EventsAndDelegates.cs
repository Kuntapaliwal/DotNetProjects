using System;

namespace DelegatesAndEvents
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            //Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }

    }

    public class EventsExercise
    {

        public void run()
        {
            Console.WriteLine("Run Fire Alarm ringing");
        }
        public void goToPlatform()
        {
            Console.WriteLine("Train came reach to platform");
        }
        public void goToInquiryCounter()
        {
            performInquiry();
        }
        public void performInquiry()
        {
            Console.WriteLine("Reached Enquiry Country please do attand your call");
        }
        public void watchMovie()
        {
            Console.WriteLine("Train is late by 6 hrs enjoy the railway views and watch movie");
        }


    }
}