using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class BankAccount
    {
        
        protected double Balance { get; set; }

        public BankAccount(double balance)
        {
            Balance = balance;
        }

        protected void PrintBalance()
        {
            Console.WriteLine(Balance);
        }

    }
}
