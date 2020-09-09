namespace BankAccount
{
    public class Checking : Account
    {
        public Checking(double balance)
        {
            this.balance = balance;
            AccountType = "Checking Account";
        }
    }
}