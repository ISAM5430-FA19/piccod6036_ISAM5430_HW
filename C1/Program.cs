using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 20; i > 0; i--)
                Console.Write(i + " ");
            Console.WriteLine();

            for (int i = 2; i <= 10; i+=2)
                Console.Write(i + " ");
            Console.WriteLine();

            for (int i = 10; i < 100; i+=10)
                Console.Write(i + " ");
            Console.WriteLine();

            for (int i = 1; i <= 20; i+=2)
                if (i % 3 != 0)
                    Console.Write(i + " ");
            Console.WriteLine();

            for (int i = 4; i < 10; i++)
                Console.Write(i * i + " ");
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
                if ((i % 3 == 0) == (i % 5 == 0))
                    Console.Write(i + " ");
            Console.WriteLine();

            for (int i = 0; i < 26; i++)
                Console.Write((char) (i + 97));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
