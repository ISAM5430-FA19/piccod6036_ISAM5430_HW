using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4B1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        Console.Write($"{i}, {j}; ");
                    }
                }

            }

            Console.WriteLine("\nwith one number:");

            //with one number

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine("\npermutations with 3 numbers");

            //permutations with 3 numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    for (int k = 1; k <= 5; k++)
                    {

                        if (i != j && j != k && i != k)
                        {
                            Console.Write($"{i}, {j}, {k}; ");
                        }

                    }
                }

            }

            //product permutations with 3 numbers
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    for (int k = 1; k <= 5; k++)
                    {

                        if (i != j && j != k && i != k)
                        {
                            sum += i * j * k;
                        }

                    }
                }

            }
            Console.WriteLine(sum);



            //product permutations with 2 numbers
            sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        sum += i * j;
                    }
                }

            }
            Console.WriteLine(sum);



        }
    }
}
