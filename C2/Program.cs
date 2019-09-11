using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 7; i++)
                Console.Write(Math.Pow(2, i) + " ");
            Console.WriteLine();

            int n = 100;
            for (int i = 0; i < 8; i++) {
                Console.Write(n + " ");
                n /= 2;
            }
            Console.WriteLine();

            decimal x = 100;
            for (int i = 0; i < 7; i++)
            {
                Console.Write(x + " ");
                x /= 2.0m;
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
