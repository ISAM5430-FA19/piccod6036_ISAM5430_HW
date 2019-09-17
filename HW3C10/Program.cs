using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3C10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of loops");
            int numLoops = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numLoops; i++)
            {
                for (int j = 1; j <= numLoops; j++)
                {
                    Console.Write('X');
                }
                Console.WriteLine();
            }


        }
    }
}
