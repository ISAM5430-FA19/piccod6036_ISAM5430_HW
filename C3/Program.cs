using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            for (int i = 1; i < 7; i++)
            {
                f *= i;
                Console.Write(f + " ");
            }
            Console.WriteLine();

            int x = 0;
            int y = 1;
            for (int i = 0; i < 25; i++)
            {
                Console.Write(x + " ");
                int temp = x;
                x += y;
                y = temp;
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
