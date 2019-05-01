using System;
using System.Linq;

namespace _09_IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                int index = i- 97;
                Console.WriteLine($"{word[i]} -> {index}");

            }
        }
    }
}
