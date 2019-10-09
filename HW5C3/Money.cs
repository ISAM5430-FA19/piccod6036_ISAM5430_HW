using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW5C3
{
    class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public Money(decimal amount)
        {
            Dollars = Convert.ToInt32(amount);
            Cents = Convert.ToInt32(amount % 1 * 100);
                                   
        }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public override string ToString()
        {
             return String.Format("{0:C}", Dollars + Cents * .01);
        }

        public void IncrementMoney(decimal amount)
        {
            Dollars = Convert.ToInt32(this.Change() + amount);
            Cents = Convert.ToInt32((this.Change() + amount) % 1 * 100);
        }

        public void DecrementMoney(decimal amount)
        {
            decimal newamt = this.Change() - amount;
            if (newamt >= 0)
            {

                Dollars = Convert.ToInt32(this.Change() - amount);
                Cents = Convert.ToInt32((this.Change() - amount) % 1 * 100);
            }
            else
            {
                WriteLine("Can't decrement money lower than zero.");
            }
        }

        public decimal Change()
        {
            return Convert.ToDecimal(Dollars + Cents * .01);
        }

        public string NumCoins()
        {
            int dollars = Dollars;
            int quarters = Cents / 25;
            int dimes = (Cents - (quarters * 25)) / 10;
            int nickels = (Cents - (dimes * 10) - (quarters * 25)) / 5;
            int pennies = (Cents - (nickels * 5) - (dimes * 10) - (quarters * 25));

            return @"Dollars: " + dollars.ToString()
                + "\nQuarters: " + quarters.ToString()
                + "\nDimes: " + dimes.ToString()
                + "\nNickels: " + nickels.ToString()
                + "\nPennies: " + pennies.ToString();
        }


    }
}
