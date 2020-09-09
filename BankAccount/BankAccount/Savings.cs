namespace BankAccount
{
    public class Savings : Account
    {
        public Savings(double balance)
        {
            this.balance = balance;
            AccountType = "Savings Account";
        }
    }
}