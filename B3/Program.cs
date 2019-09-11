using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a deciaml number between 0 and 4");
            decimal a = decimal.Parse(Console.ReadLine());

            if (a < 0 || a > 4)
                Console.WriteLine("Invalid GPA");
            else
                Console.WriteLine(new[] { "F", "F", "F", "C-", "C", "C+", "B-", "B", "B+", "A-", "A" }[(int)(3 * a + 0.5m)]);

            Console.ReadLine();
        }
    }
}   
