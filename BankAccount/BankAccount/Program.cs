using System;

namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Ashen", "Malaka");
            Savings savings = new Savings(10000);
            Checking checking = new Checking(2000);

            string fullName = account.DisplayAccountHolderFullName();
            Console.WriteLine(fullName);

        }
    }
}