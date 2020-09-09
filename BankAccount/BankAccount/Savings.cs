namespace BankAccount
{
    public class Savings : Account
    {
        public Savings(double balance)
        {
            this.balance = balance;
            accountType = "Savings Account";
        }
    }
}