using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(50.00M);
            Account account2 = new Account(-7.53M);

            WriteLine("account1 balance: {0:C}", account1.Balance);
            WriteLine("account2 balance: {0:C}\n", account2.Balance);

            decimal depositAmount;

            Write("Enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account1 balance\n", depositAmount);
            account1.Credit(depositAmount);

            WriteLine("account1 balance: {0:C}", account1.Balance);
            WriteLine("account2 balance: {0:C}\n", account2.Balance);

            Write("Enter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account2 balance\n", depositAmount);
            account2.Credit(depositAmount);

            WriteLine("account1 balance: {0:C}", account1.Balance);
            WriteLine("account2 balance: {0:C}", account2.Balance);

            decimal withdrawalAmount;

            Write("Enter withdrawal amount for account1: ");
            withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("withdrawing {0:C} from account1 balance\n", withdrawalAmount);
            account1.Withdraw(withdrawalAmount);

            WriteLine("account1 balance: {0:C}", account1.Balance);
            WriteLine("account2 balance: {0:C}\n", account2.Balance);

            Write("Enter withdrawal amount for account2: ");
            withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("withdrawing {0:C} from account2 balance\n", withdrawalAmount);
            account2.Withdraw(withdrawalAmount);

            WriteLine("account1 balance: {0:C}", account1.Balance);
            WriteLine("account2 balance: {0:C}\n", account2.Balance);

        }
    }
}
