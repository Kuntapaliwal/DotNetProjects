namespace Shopping
{
    public partial class Customer
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public int CustomerId { get; set; }

        public Customer(){}

        public Customer(String name,String address,int customerId)
        {
            this.Name = name;this.Address = address;this.CustomerId = customerId;
        }

        partial void BuyWithCard();

        partial void BuyWithCash();


    }
}