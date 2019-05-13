using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (current == ' ')
                {
                    continue;
                }

                if (!counts.ContainsKey(current))
                {
                    counts[current] = 0;
                }

                counts[current] += 1;

            }

            foreach (var item in counts)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
