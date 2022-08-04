namespace InterfaceNameSpace
{

    struct Task1
    {
        public int sum(int x, int y)
        {
            return x + y;
        }

    }
    struct TimeTask
    {
        public readonly int hour = 0;//we need to intialise readonly before ending the program 
        public readonly int minute = 0;
        public TimeTask(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }
        public TimeTask(int minute)
        {

            this.minute = minute;

        }
        public int Hour { get { return hour; } }
        public int Minutes { get { return minute; } }

        public override string ToString()
        {
            int hourdata = Minutes / 60;
            int minutesdata = Minutes % 60;

            return base.ToString() + "time:" + hourdata + ":" + minutesdata;
        }
    }

    struct Book
    {
        public string title;
        public string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        public void DisplayDetail()
        {
            Console.WriteLine("Title = {0} Author = {1}.", title, author);
        }
    }



    public struct Time
    {
        private readonly int minutes;
        public Time(int hh, int mm)
        {
            this.minutes = 60 * hh + mm;
        }
        public override String ToString()
        {
            return minutes.ToString();
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
            Task1 t1 = new Task1();
            System.Console.WriteLine("sum: {0}", t1.sum(3, 5));

            TimeTask time = new TimeTask(23, 54);
            System.Console.WriteLine(time.Hour);
            System.Console.WriteLine(time.Minutes);

            TimeTask time2 = new TimeTask(605);
            System.Console.WriteLine(time2.ToString());

            Book s2 = new Book("BASIC", "S.TROELSTRA");
            s2.DisplayDetail();

            Book s3 = new Book("C+", "G.RTRTG");
            s3.DisplayDetail();

            //task 3
            Time timer = new Time(4, 50);
            Console.WriteLine(timer.ToString() + " Minutes");

        }
    }
}
