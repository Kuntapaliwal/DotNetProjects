namespace Shopping
{
    public partial class Customer
    {
        partial void BuyWithCard()
        {
            System.Console.WriteLine("Payment With Card Done Succesfully");
        }
        partial void BuyWithCash()
        {
            System.Console.WriteLine("Payment With Cash Done Succesfully");
        }

        public void Buy(PaymentMode paymentMode)
        {
            System.Console.WriteLine(paymentMode);
            switch (paymentMode)
            {
                case PaymentMode.CARD:
                        BuyWithCard();
                        break;
                case PaymentMode.CASH:
                        BuyWithCash();
                        break;
                default:
                        System.Console.WriteLine("Payment mode not supported.");
                        break;
            }
        }
        public void DispalyCostmerDetails()
        {
            System.Console.WriteLine("name:{0}\t Address:{1}\t CustomerId:{2}",Name,Address,CustomerId);
        }


    }
}