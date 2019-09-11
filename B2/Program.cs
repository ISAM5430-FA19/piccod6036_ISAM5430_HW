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
            Console.WriteLine("Enter the first integer");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third integer");
            int c = int.Parse(Console.ReadLine());

            Console.Write("The middle integer is ");
            if (a > b && b < c)
                Console.WriteLine(a);
            else if (b > a && a < c)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);

            Console.ReadLine();


        }
    }
}
