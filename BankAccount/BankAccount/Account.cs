using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

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
        public string AccountType { get => accountType; set => accountType = value; }
        public double Balance { get => balance; }

        public Account()
        {
            firstName = "Ashen";
            lastName = "Malaka";
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

        public void WriteSummary(IList<string> transactions, string fileName)
        {
            try
            {
                using (StreamWriter summary = new StreamWriter(fileName + ".txt", true))
                {
                    foreach (string transaction in transactions)
                    {
                        summary.WriteLine(transaction);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }

    }
}