using System;

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

            string userChoice = "";

            do
            {
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
                        Console.WriteLine("Thanks and come again!");
                        Environment.Exit(0);
                        break;
                }

            } while (userChoice.ToUpper() != "X");
            
        }
    }
}