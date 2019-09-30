using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4B12
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {

                    Console.Write($"{i}, {j}; ");

                }

            }

            Console.WriteLine("\nwith three numbers:");


            //combinations with 3 numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {


                        Console.Write($"{i}, {j}, {k}; ");


                    }
                }

            }


            Console.WriteLine("\nwith four numbers:");


            //combinations with 4 numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {

                            Console.Write($"{i}, {j}, {k}, {l}; ");
                        }

                    }
                }

            }



            Console.WriteLine("\nwith five numbers:");


            //combinations with 5 numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {

                            for (int m = l + 1; m <= 5; m++)
                            {

                                Console.Write($"{i}, {j}, {k}, {l}, {m}; ");

                            }
                        }

                    }
                }

            }

            int sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {

                    sum += i * j;

                }

            }

            Console.WriteLine(sum);
            sum = 0;

            //combinations with 3 numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {


                        sum += i * j * k;


                    }
                }

            }


            Console.WriteLine(sum);

            sum = 0;
            //combinations with 4 numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {

                            sum += i * j * k * l;
                        }

                    }
                }

            }



            Console.WriteLine(sum);

            sum = 0;
            //combinations with 5 numbers
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {

                            for (int m = l + 1; m <= 5; m++)
                            {

                                sum += i * j * k * l * m;

                            }
                        }

                    }
                }

            }
            Console.WriteLine(sum);


        }
    }
}
