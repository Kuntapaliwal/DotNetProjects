namespace AccountNameSpace
{
    // public enum transactionType
    // {
    //     WITHDRAWL,DEPOSIT;
    // }
    public class Account
    {
        double balance;
        string accHoldername;

        public Account()
        {

        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string AccHoldername
        {
            get { return accHoldername; }
            set { accHoldername = value; }
        }

        public double deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
            }
            // var dateTime = System.currentTimeMillis();
            // var transactionTime = new Timestamp(dateTime);
            // var date = Date.from(transactionTime.toInstant());
            // Console.WriteLine("date is like.........." + string.Join(", ", date));
            // this.sendTransactionMesaage(amount, transactionType.DEPOSIT, DateTime.now());
            return this.balance;
        }

        
        public double withdraw(double amount)
        {
            // this.sendTransactionMesaage(amount, transactionType.WITHDRAWL, DateTime.now());
            return this.balance - amount;
        }
        // public double calculateInterest(double amount)
        // {
        //     return (amount * java_programs.Account.interestRate) / 100;
        // }
        public void setbalance(double balance)
        {
            this.balance = balance;
        }
        public double getbalance()
        {
            return this.balance;
        }
        public void sendTransactionMesaage(double amount, int mode)
        {
            var message = "hello .....";
            switch (mode)
            {
                case 0:
                    message = message + "withdraw amount " + amount + " total balance " + this.balance ;
                    break;
                case 1:
                    message = message + "deposit amount " + amount + " total balance " + this.balance;
                    break;
                default:
                    message = message + "Invalid transaction attempted at your account at time ";
                    break;
            }
            Console.WriteLine(message);
        }
    

        


    }
}