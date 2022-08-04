namespace CircularQueueNamespace
{
    class CircularQueueClass
    {
        int[] queue = new int[100];
        int max = 100, front = -1, rear = -1;
        public void QueueEnque(int element)
        {
            
            if (front == -1 && rear == -1)   // condition to check queue is empty  
            {
                front = 0;
                rear = 0;
                queue[rear] = element;
            }
            else if ((rear + 1) % max == front)
                Console.WriteLine("Queue Overflow");
            else
            {
                rear = (rear + 1) % max;       // rear is incremented  
                queue[rear] = element;
            }
        }
        public void QueueDeque()
        {
            if ((front == -1) && (rear == -1))
            {
                Console.WriteLine("Queue Underflow ");
            }
            else if (front == rear)
            {
                Console.WriteLine("pooped element from Queue is {0} ", queue[front]);
                front = -1;
                rear = -1;
            }
            else{
                Console.WriteLine("pooped element from Queue is {0} ", queue[front]);
                front = (front + 1) % max;
            }
        }
        public int QueuePeek()
        {
            if ((front == -1) && (rear == -1))
            {
                Console.WriteLine("there is no element in Queue");
                return -1;
            }

            return front;
        }
        public void QueueDisplay()
        {
            int i=front;
            if (front == -1 && rear == -1)
            {
                Console.WriteLine("there is no element in Queue");
               
            }
            else
            {
                while (i <= rear)
                {
                    Console.Write(queue[i] + " ");
                    i = (i + 1) % max;
                }
            }
        }
    }
}