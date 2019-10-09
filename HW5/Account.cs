using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW5
{
    class Account
    {
        private decimal _balance;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
            }
        }

        //constructor
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Credit(decimal amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw (decimal amount)
        {
            if (amount > Balance)
            {
                WriteLine("Withdrawal amount exceeded account balance.");
            }
            else
            {
                Balance = Balance - amount;
            }
        }
    }
}
