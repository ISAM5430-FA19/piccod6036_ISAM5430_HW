using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW5C3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(Convert.ToDecimal(12.45));
            WriteLine(m1.ToString());
            m1.IncrementMoney(Convert.ToDecimal(.01));
            WriteLine(m1.ToString());
            WriteLine(m1.NumCoins());

            Money m2 = new Money(12,45);
            WriteLine(m2.ToString());
            m2.DecrementMoney(Convert.ToDecimal(13.00));
            WriteLine(m2.ToString());
            WriteLine(m2.NumCoins());
        }
    }
}
