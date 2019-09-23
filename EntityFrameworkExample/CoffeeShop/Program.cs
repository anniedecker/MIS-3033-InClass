using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string w = Console.ReadLine();
            string reverseW = ReverseWord(w);

            if (w == reverseW)
            {
                Console.WriteLine($"Woah, {w} is a palindrome!");
            }
            else
            {
                Console.WriteLine(reverseW);
            }
            Console.ReadKey();
        }
        static string ReverseWord(string word)
        {
            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            return reversed;
        }
    }
}
