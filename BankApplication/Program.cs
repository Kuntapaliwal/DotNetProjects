// See https://aka.ms/new-console-template for more information
using AccountNameSpace;
using Discussion11;

class Driver
{
    static void Main(string[] args)
    {
      Account account = new Account();
      account.Balance=100000;
      account.AccHoldername="Kunta";

      Console.WriteLine("name:{0}  acountHolder:{1}",account.Balance,account.AccHoldername);

        Console.WriteLine(account.Balance);
        account.Balance=1000;
        Console.WriteLine(account.Balance);
        Console.WriteLine(account.deposit(100));
        Console.WriteLine(account.Balance);
        Console.WriteLine(account.withdraw(100));
        account.deposit(100);


        Student stu = new Student();
        stu.Name = "Ram";
        stu.RollNo = 25;

        Console.WriteLine(stu);
        Student stu1 = new Student("kunta",21);
        Console.WriteLine(stu1);

    }
}
