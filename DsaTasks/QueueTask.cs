namespace QueueNamespace
{
    class QueueClass
    {
        int[] myQueue =new int[100];
        int n = 100, front = -1, rear = -1;
        public void QueueEnque(int data)
        {
            if (rear == n - 1)
                Console.WriteLine("Queue Overflow");
            else
            {

                if (front == -1)
                    front = 0;
                rear++;
                myQueue[rear] = data;

            }
        }
        public void QueueDeque()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue Underflow ");
            }
            else
            {
                Console.WriteLine("pooped element from Queue is {0} ", myQueue[front]);
                rear--;
            }
        }
        public int QueuePeek()
        {
            if (front <= -1)
            {
                Console.WriteLine("there is no element in Queue");
                return -1;
            }

            return front;
        }
        public void QueueDisplay()
        {
            if (rear >= 0)
            {
                for (int i = front; i <= rear; i++)
                    Console.Write(myQueue[i] + " ");
            }
            else
            {
                Console.WriteLine("there is no element in Queue");
            }
        }
    }
}