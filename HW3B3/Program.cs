using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3B3
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = int.Parse(Console.ReadLine());
            int previous = int.MinValue;

            while (previous < current)
            {
                previous = current;
                current = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The largest is: {previous}");

        }
    }
}
