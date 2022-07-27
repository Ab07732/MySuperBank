using System;

namespace MySuperBank 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra",10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);
        }
    }
}