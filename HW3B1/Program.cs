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

            Console.WriteLine("Enter numbers: ");
            int score = int.Parse(Console.ReadLine());
            
            int total = 0;
            double count = 0;
            int max = 0;
            while (score >= 0 && score <= 100)
            {
                total += score;
                if (score > max)
                {
                    max = score;
                }
                count++;
                score = int.Parse(Console.ReadLine());
            }
            if (count == 0)
            {
                Console.WriteLine("Nothing entered.");
            }
            else
            {
                Console.WriteLine($"Average score is {total / count}");
                Console.WriteLine($"Max score is {max}");
            }
        }
    }
}
