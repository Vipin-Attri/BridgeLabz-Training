using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class BankAccount
    {
        private string AccountNumber;
        private string AccountHoldername;
        private double Balance;

        //Constructor
        public BankAccount(string AccountNumber, string AccountHoldername, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHoldername = AccountHoldername;
            this.Balance = Balance;
        }
        //Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount.ToString()}. New Balance: {Balance.ToString()}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
            
        }
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount.ToString()}. New Balance: {Balance.ToString()}");
            }
            else
            {
                Console.WriteLine("Insufficientfunds or invalid withdrawal amount.");
            }

        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Current Balance: {Balance.ToString()}");
        }
    }
}
