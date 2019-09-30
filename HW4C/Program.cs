using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4C
{
    class Program
    {

        static void Main(string[] args)
        {
            char letter = char.ToUpperInvariant(Console.ReadKey().KeyChar), last = '\0';

            int consonants = 0, vowels = 0, syllables = 0, order = 0;
            Boolean increasing, musical, last_half, alternate_vowels_constants, smooth, alternate_alphabet_position;
            increasing = musical = last_half = alternate_vowels_constants = smooth = alternate_alphabet_position = true;

            while (char.IsLetter(letter))
            {
                if (IsVowel(letter))
                    vowels++;
                else
                    consonants++;

                //if this is the first character
                if (last != 0)
                {
                    if (!IsVowel(last) && IsVowel(letter))
                        syllables++;
                    if (last >= letter)
                        increasing = false;
                    if (IsVowel(last) == IsVowel(letter))
                        alternate_vowels_constants = false;
                    if (last > letter + 1 || last < letter - 1)
                        smooth = false;
                    //C9f
                    if (order == 0)
                        if (last < letter)
                            order = 1;
                        else if (last > letter)
                            order = -1;
                        else
                            alternate_alphabet_position = false;
                    else
                        if ((last < letter && order == 1) || (last > letter && order == -1) || last == letter)
                        alternate_alphabet_position = false;
                    else
                        order *= -1;
                }
                else if (IsVowel(letter))
                    syllables++;
                
                if (!"CDEFGAB".Contains(letter))
                    musical = false;
                if (letter < 'N')
                    last_half = false;

                last = letter;
                letter = char.ToUpperInvariant(Console.ReadKey().KeyChar);
            }

            Console.WriteLine($"There were {vowels + consonants} letters entered.");
            Console.WriteLine($"There were {vowels} vowels and {consonants} consonants.");
            Console.WriteLine($"There were {syllables} syllables.");
            Console.WriteLine($"The letters {(increasing ? "are" : "are not")} in increasing order.");
            Console.WriteLine($"You {(musical ? "can" : "can't")} play this word on a musical instrument.");
            Console.WriteLine($"The letters {(last_half ? "are" : "are not")} from the second half of the alphabet.");
            Console.WriteLine($"The letters{(alternate_vowels_constants ? "" : " don't")} alternate between vowels and consonants.");
            Console.WriteLine($"The letters {(smooth ? "have" : "don't have")} smooth transitions.");
            Console.WriteLine($"The letters {(alternate_alphabet_position ? "are" : "aren't")} in alternating position.");
        }

        static Boolean IsVowel(char c)
        {
            return "AEIOUY".Contains(c);
        }
    }
}
