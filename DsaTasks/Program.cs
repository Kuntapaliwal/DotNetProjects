// See https://aka.ms/new-console-template for more information
 using StackNamespace;
 using System;
using QueueNamespace;
using CircularQueueNamespace;
class Driver
{
    static void Main(string[] args)
    {
        StackClass myStackClass = new StackClass();
Console.WriteLine("...............................................Stack Operations.................................................");
        int ch, val;
        Console.WriteLine("1) Push in Queue");
        Console.WriteLine("2) Pop from stack");
        Console.WriteLine("3) Display Stack");
        Console.WriteLine("4) Get Peek element");
        Console.WriteLine("5) Exit");
        do
        {
            Console.WriteLine("Enter choice: ");
            
           ch= System.Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        System.Console.WriteLine("Enter value to be pushed:");

                        val = System.Convert.ToInt32(Console.ReadLine());
                        myStackClass.StackPush(val);
                        break;
                    }
                case 2:
                    {
                        myStackClass.StackPop();
                        break;
                    }
                case 3:
                    {
                        myStackClass.StackDisplay();
                        break;
                    }
                    case 4:
                    {
                        myStackClass.StackPeek();
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
            
        }while (ch != 5);


        //queue operation


        QueueClass myQueueClass = new QueueClass();
        Console.WriteLine("...............................................Queue Operations.................................................");
        int chq, valq;
        Console.WriteLine("1) insert in Queue");
        Console.WriteLine("2) Delete  from Queue");
        Console.WriteLine("3) Display Queue");
        Console.WriteLine("4) Get Peek element");
        Console.WriteLine("5) Exit");
        do
        {
            Console.WriteLine("Enter chqoice: ");

            chq = System.Convert.ToInt32(Console.ReadLine());
            switch (chq)
            {
                case 1:
                    {
                        System.Console.WriteLine("Enter valuue to be insertd:");

                        valq = System.Convert.ToInt32(Console.ReadLine());
                        myQueueClass.QueueEnque(valq);
                        break;
                    }
                case 2:
                    {
                        myQueueClass.QueueDeque();
                        break;
                    }
                case 3:
                    {
                        myQueueClass.QueueDisplay();
                        break;
                    }
                case 4:
                    {
                        myQueueClass.QueuePeek();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Exited");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }

        } while (chq != 5);

        //Circular queue operation


        CircularQueueClass myCircularQueueClass = new CircularQueueClass();
        Console.WriteLine("...............................................Circular Queue Operations.................................................");
        int chcq, valcq;
        Console.WriteLine("1) insert in Queue");
        Console.WriteLine("2) Delete  from Queue");
        Console.WriteLine("3) Display Queue");
        Console.WriteLine("4) Get Peek element");
        Console.WriteLine("5) Exit");
        do
        {
            Console.WriteLine("Enter chqoice: ");

            chcq = System.Convert.ToInt32(Console.ReadLine());
            switch (chcq)
            {
                case 1:
                    {
                        System.Console.WriteLine("Enter valuue to be insertd:");

                        valcq = System.Convert.ToInt32(Console.ReadLine());
                        myCircularQueueClass.QueueEnque(valcq);
                        break;
                    }
                case 2:
                    {
                        myCircularQueueClass.QueueDeque();
                        break;
                    }
                case 3:
                    {
                        myCircularQueueClass.QueueDisplay();
                        break;
                    }
                case 4:
                    {
                        myCircularQueueClass.QueuePeek();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Exited");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }

        } while (chcq != 5);

        
    }   

}
