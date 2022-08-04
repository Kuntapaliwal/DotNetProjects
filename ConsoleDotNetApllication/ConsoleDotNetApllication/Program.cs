namespace ConsoleDotNetApllication
{
    class Driver
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***************Welcome to Car Service*****************"+"\n");
            int choice;
            do
            {
                System.Console.WriteLine("Enter the car choice you are looking for");
                System.Console.WriteLine("1.Honda");
                System.Console.WriteLine("2.Kia");
                System.Console.WriteLine("3.Maruti");
                System.Console.WriteLine("4.Quit"+"\n");
                choice = System.Convert.ToInt32(System.Console.ReadLine());
                ICar car = null;
                switch (choice)
                {
                    case 1:
                        car = FactoryDesign.getCar("Honda");
                        break;
                    case 2:
                        car = FactoryDesign.getCar("Kia");
                        break;
                    case 3:
                        car = FactoryDesign.getCar("Maruti");
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our service");
                        break;
                    default:
                        Console.WriteLine("Invalid  Choice");
                        break;
                }
                if (car != null)
                {
                    Console.WriteLine("\n"+"CarType : " + car.GetCarType()+"\n");

                }
            } while (choice!=4);


            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}


