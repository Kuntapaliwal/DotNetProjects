namespace InterfaceNameSpace
{

    class Driver
    {
        static void Main(string[] args)
        {
            int n = System.Convert.ToInt32(System.Console.ReadLine());
            int[] arr = new int[n];
            TestClass T = new TestClass();

            for (int i = 0; i < n; i++)
            {
                arr[i] = System.Convert.ToInt32(System.Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                T.Display(arr[i]);
            }
        }
    }

}


