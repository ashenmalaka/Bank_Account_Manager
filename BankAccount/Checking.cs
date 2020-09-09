namespace BankAccount
{
    public class Checking : Account
    {
        public Checking(double balance)
        {
            this.balance = balance;
            accountType = "Checking Account";
        }
    }
}