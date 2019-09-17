using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = int.Parse(Console.ReadLine());
            int previous = int.MaxValue;
            int sum = current;
            
            while (previous != current)
            {
                previous = current;
                current = int.Parse(Console.ReadLine());
                sum += current;

            }

            Console.WriteLine($"Sum is {sum}");

        }
    }
}
