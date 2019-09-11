using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a count");
            int count = int.Parse(Console.ReadLine());

            int posCount = 0;
            int zeroCount = 0;
            int evenCount = 0;
            int lastNumber = int.MinValue;
            Boolean increasingOrder = true;
            int largest = int.MinValue;
            int smallest = int.MaxValue;
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter an integer");
                int ans = int.Parse(Console.ReadLine());
                if (ans > 0)
                    posCount++;
                if (ans == 0)
                    zeroCount++;
                if (ans % 2 == 0)
                    evenCount++;
                if (ans < lastNumber)
                    increasingOrder = false;
                lastNumber = ans;
                if (ans > largest)
                    largest = ans;
                if (ans < smallest)
                    smallest = ans;
                if (i < count / 2)
                    sum += ans;
                if (i > count / 2)
                    sum -= ans;

            }
            Console.WriteLine($"The number of positive numbers is {posCount}");
            Console.WriteLine($"The number of zeros is {zeroCount}");
            Console.WriteLine($"The number of even numbers is {evenCount}");
            Console.WriteLine($"The numbers {(increasingOrder ? "are" : "are not")} in increasing order");
            Console.WriteLine($"The largest number is {largest}");
            Console.WriteLine($"The smallest number is {smallest}");
            Console.WriteLine($"The two halves {(sum == 0 ? "have" : "don't have")} equal sums");
            
            Console.ReadLine();

        }
    }
}
