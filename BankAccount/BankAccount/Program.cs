using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account();
            Savings savings = new Savings(10000);
            Checking checking = new Checking(2000);

            string clientInfo = account.DisplayAccountHolderFullName();
            string checkingAccountType = checking.AccountType;
            string savingsAccountType = savings.AccountType;

            IList<string> checkingAccountSummary = new List<string>();
            IList<string> savingsAccountSummary = new List<string>();

            checkingAccountSummary.Add(clientInfo);
            checkingAccountSummary.Add(checkingAccountType);

            savingsAccountSummary.Add(clientInfo);
            savingsAccountSummary.Add(savingsAccountType);

            string userChoice = "";

            do
            {
                string checkingDepositAmount = ($"Transaction: +${checking.DepositAmount} at {DateTime.Now}" +
                    $"Current Balance: ${checking.Balance}");
                string savingsDepositAmount = ($"Transaction: +${savings.DepositAmount} at {DateTime.Now}" +
                    $"Current Balance: ${savings.Balance}");
                string checkingWithrdawAmount = ($"Transaction: -${checking.WithdrawAmount} at {DateTime.Now}" +
                    $"Current Balance: ${checking.Balance}");
                string savingsWithrdawAmount = ($"Transaction: -${savings.WithdrawAmount} at {DateTime.Now}" +
                    $"Current Balance: ${savings.Balance}");

                account.DisplayFirstMessage();
                Console.ReadLine();

                account.DisplayMenu();
                userChoice = Console.ReadLine();

                switch (userChoice.ToUpper())
                {
                    case "I":
                        Console.Clear();
                        Console.WriteLine(clientInfo);
                        break;
                    case "CB":
                        Console.Clear();
                        checking.AccountBalance();
                        Console.WriteLine("Checking Account Balance: ${0}", checking.Balance);
                        break;
                    case "SB":
                        Console.Clear();
                        savings.AccountBalance();
                        Console.WriteLine("Savings Account Balance: ${0}", savings.Balance);
                        break;
                    case "CD":
                        Console.Clear();
                        Console.WriteLine("How much would you like to deposit?");
                        checking.DepositAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: ${0}", checking.DepositAmount);
                        checking.DepositBalance(checking.DepositAmount);
                        break;
                    case "SD":
                        Console.Clear();
                        Console.WriteLine("How much would you like to deposit?");
                        savings.DepositAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: ${0}", savings.DepositAmount);
                        savings.DepositBalance(savings.DepositAmount);
                        break;
                    case "CW":
                        Console.Clear();
                        Console.WriteLine("How much would you like to withdraw?");
                        checking.WithdrawAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: ${0}", checking.WithdrawAmount);
                        checking.WithdrawBalance(checking.WithdrawAmount);
                        break;
                    case "SW":
                        Console.Clear();
                        Console.WriteLine("How much would you like to withdraw?");
                        checking.WithdrawAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: ${0}", checking.WithdrawAmount);
                        checking.WithdrawBalance(checking.WithdrawAmount);
                        break;
                    case "X":
                        Console.Clear();
                        account.WriteSummary(checkingAccountSummary, "Checking");
                        account.WriteSummary(savingsAccountSummary, "Savings");
                        Console.WriteLine("Thanks and come again!");
                        Environment.Exit(0);
                        break;
                }

            } while (userChoice.ToUpper() != "X");
            
        }
    }
}