using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class SavingsAccount : BankAccount
    {
        private double InterestRate { get; set; }
        public SavingsAccount(double balance, double interestRate) : base(balance)
        {
            InterestRate = interestRate;

        }

        public void CalculateInterest()
        {
            double interest = Balance * InterestRate;
            Balance = interest;
        }
    }
}

