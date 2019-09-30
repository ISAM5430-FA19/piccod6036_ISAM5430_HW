using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4B23
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                    if (IsVowel(i) || IsVowel(j))
                        Console.Write($"{i}{j}, ");
            Console.WriteLine("\n");

            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                    if (IsVowel(i) != IsVowel(j))
                        Console.Write($"{i}{j}, ");
            Console.WriteLine("\n");

            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                    if (IsVowel(i) && !IsVowel(j))
                        Console.Write($"{i}{j}, ");
            Console.WriteLine("\n");

            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                    for (char k = 'A'; k <= 'H'; k++)
                        if (IsVowel(i) || IsVowel(j) || IsVowel(k))
                            Console.Write($"{i}{j}{k}, ");
            Console.WriteLine("\n");

            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                    for (char k = 'A'; k <= 'H'; k++)
                        if (IsVowel(j))
                            Console.Write($"{i}{j}{k}, ");
            Console.WriteLine("\n");

            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                    for (char k = 'A'; k <= 'H'; k++)
                        if ((IsVowel(i) || IsVowel(j) || IsVowel(k)) && ((!IsVowel(i) || !IsVowel(j) || !IsVowel(k))))
                            Console.Write($"{i}{j}{k}, ");
            Console.WriteLine("\n");

            //?
            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                    for (char k = 'A'; k <= 'H'; k++)
                        if (IsVowel(i) || IsVowel(j) || IsVowel(k))
                            Console.Write($"{i}{j}{k}, ");
            Console.WriteLine("\n");
            //?

            //B.2.5.a
            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                {
                    if (IsVowel(i) || IsVowel(j))
                        Console.Write($"{i}{j}, ");
                    for (char k = 'A'; k <= 'H'; k++)
                        if (IsVowel(i) || IsVowel(j) || IsVowel(k))
                            Console.Write($"{i}{j}{k}, ");
                }
            Console.WriteLine("\n");

            //B.2.5.b
            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                {
                    if (!IsVowel(i) && IsVowel(j))
                        Console.Write($"{i}{j}, ");
                    for (char k = 'A'; k <= 'H'; k++)
                        if (!IsVowel(i) && IsVowel(k))
                            Console.Write($"{i}{j}{k}, ");
                }
            Console.WriteLine("\n");

            //B.2.5.c
            //?
            for (char i = 'A'; i <= 'H'; i++)
                for (char j = 'A'; j <= 'H'; j++)
                {
                    if (IsVowel(i) || IsVowel(j))
                        Console.Write($"{i}{j}, ");
                    for (char k = 'A'; k <= 'H'; k++)
                        if (IsVowel(i) || IsVowel(j) || IsVowel(k))
                            Console.Write($"{i}{j}{k}, ");
                }
            Console.WriteLine("\n");
            //?

            
        }

        static Boolean IsVowel(char c)
        {
            return "AEIOUYaeiouy".Contains(c);
        }
    }
}
