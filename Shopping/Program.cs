namespace Shopping

{

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Rohan","Manyata",01);
        Customer customer2 = new Customer{Name="Mohit",Address ="Nagwara", CustomerId= 02};
        customer1.Buy(PaymentMode.CARD);
        customer2.Buy(PaymentMode.CASH);
    
        

        

    }

}
}
