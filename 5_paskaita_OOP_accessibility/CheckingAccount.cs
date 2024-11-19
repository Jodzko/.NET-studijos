using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class CheckingAccount : BankAccount
    {
        private int OverdraftLimit { get; set; }
        public CheckingAccount(double balance, int overdraftLimit) : base(balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public void Withdraw(int withdrawAmount)
        {
            if((Balance - OverdraftLimit) > withdrawAmount)
            {
                Balance = Balance - withdrawAmount;
            }
        }
    }
}
