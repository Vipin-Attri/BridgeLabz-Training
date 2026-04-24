using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount vipinsAccount = new BankAccount("1234567890","Vipin",10000.75);
            BankAccount vipulsAccount = new BankAccount("0987654321", "Vipul", 278591.75);

            vipinsAccount.Deposit(5000);
            vipulsAccount.Withdraw(10000);

            vipinsAccount.DisplayBalance();
            vipulsAccount.DisplayBalance();

        }
    }
}
