using DelegatesAndEvents;
class Driver
{

    public delegate void MyEvent();
    public static event MyEvent myevent;

    static void Main(string[] args)
    {
        DelegateExercises delegateExercises = new DelegateExercises();
        delegateExercises.Method2();




        EventsExercise eventsExercise = new EventsExercise();


        int ch;
        do
        {
            System.Console.WriteLine("...............................................Enter the situation.................................................");
            Console.WriteLine("1) Fire Alarm");
            Console.WriteLine("2) Train Paltform Announcement");
            Console.WriteLine("3) Enquiry Counter");
            Console.WriteLine("4) Train Delay Announcement");
            Console.WriteLine("5) Exit");
            Console.WriteLine("Enter choice: ");

            ch = System.Convert.ToInt32(Console.ReadLine());


            switch (ch)
            {
                case 1:
                    {
                        myevent = new MyEvent(eventsExercise.run);
                        //myevent();
                        break;
                    }
                case 2:
                    {
                        myevent = new MyEvent(eventsExercise.goToPlatform);
                        //myevent();
                        break;
                    }
                case 3:
                    {
                        myevent = new MyEvent(eventsExercise.goToInquiryCounter);
                        //myevent();
                        break;
                    }
                case 4:
                    {
                        myevent = new MyEvent(eventsExercise.watchMovie);
                        //myevent();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Exited");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalqid choice");
                        break;
                    }
            }
            myevent();

        } while (ch != 5);



    }
}