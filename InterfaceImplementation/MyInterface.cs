namespace InterfaceNameSpace
{
    interface MyInterface
    {
        void Display(int p);
    }

    class TestClass : MyInterface
    {
        public void Display(int p)
        {

            int count = 0;
            for (int i = 0; i <= p; i++)
            {
                if (isPrime(i))
                    count++;
            }
            System.Console.WriteLine(count);
        }

        static bool isPrime(int n)
        {
            if (n < 2)
                return false;
            // checking the number of divisors b/w 1 and the number n-1
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }

}