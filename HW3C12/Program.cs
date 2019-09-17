using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3C12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your desired number of primes");
            int num = int.Parse(Console.ReadLine());
            int lastPrime = 1;

            while (num != 0)
            {
                num--;
                while (!isPrime(lastPrime))
                {
                    lastPrime++;
                }
                Console.Write(lastPrime + " ");
                lastPrime++;
            }
            Console.ReadLine();



        }

        static Boolean isPrime(int n)
        {
            if (n == 1 || n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i < n - 1; i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
