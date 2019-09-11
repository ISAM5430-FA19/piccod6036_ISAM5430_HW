using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            int j = int.Parse(Console.ReadLine());

            if (i > j)
                Console.WriteLine("The first integer is bigger");
            else if (j > i)
                Console.WriteLine("The second integer is bigger");
            else
                Console.WriteLine("Both integers are the same");

            Console.ReadLine();


        }
    }
}
