namespace StackNamespace
{
    class StackClass
    {
        int[] mystack=new int[100];
        int n=100;
        int top=-1;
        public void StackPush(int data)
        {
            if(top>=n-1)
            Console.WriteLine("Stack Overflow");
            else{
                top++;
                mystack[top]=data;
                
            }
        }
        public void StackPop()
        {
            if(top<=-1)
            {
                Console.WriteLine("Stack Underflow ");
            }
            else{
                Console.WriteLine("pooped element from stack is {0} ",mystack[top]);
                top--;
            }
        }
        public int StackPeek()
        {
            if (top <= -1)
            {
                Console.WriteLine("there is no element in stack");
                return -1;
            }
            
            return top;
        }
        public void StackDisplay()
        {
            if(top>=0)
            {
                for (int i = top; i >= 0; i--)
                Console.Write(mystack[i]+" ");
            }
            else{
                Console.WriteLine("there is no element in stack");
            }
        }
    }
}