using System;

namespace BankAccount
{
    public class Account
    {
        private string firstName;
        private string lastName;

        protected string accountType;

        protected double balance;
        private double depositAmount;
        private double withdrawAmount;

        public double DepositAmount { get => depositAmount; set => depositAmount = value; }
        public double WithdrawAmount { get => withdrawAmount; set => withdrawAmount = value; }

        public string FirstName()
        {
            get{
                return this.firstName;
            }
        }

        public string LastName()
        {
            get{
                return this.lastName;
            }
        }

        public string AccountType()
        {
            get{
                return this.accountType;
            }
        }

        public double Balance()
        {
            get{
                return this.balance;
            }
        }

        public Account(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string DisplayAccountHolderFullName()
        {
            string accountHolderFullName = "Account Holder: " + firstName + " " + lastName;
            return accountHolderFullName;
        }

        public void DisplayFirstMessage()
        {
            Console.WriteLine("Hit Enter to Display Banking Menu");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("[I] View Account Holder Information");
            Console.WriteLine("[CB] Checking - View Balance");
            Console.WriteLine("[CD] Checking - Deposit Funds");
            Console.WriteLine("[CW] Checking - Withdraw Funds");
            Console.WriteLine("[SB] Savings - View Balance");
            Console.WriteLine("[SD] Savings - Deposit Funds");
            Console.WriteLine("[SW] Savings - Withdraw Funds");
            Console.WriteLine("[X] Exit");
        }

        public void AccountBalance()
        {
            balance = balance + depositAmount - withdrawAmount;
            depositAmount = 0;
            withdrawAmount = 0;
        }

        public void DepositBalance(double input)
        {
            depositAmount = input;
            withdrawAmount = 0;
            balance = balance + depositAmount - withdrawAmount;
        }

        public void WithdrawBalance(double input)
        {
            withdrawAmount = input;
            depositAmount = 0;
            balance = balance + depositAmount - withdrawAmount;
        }


    }
}