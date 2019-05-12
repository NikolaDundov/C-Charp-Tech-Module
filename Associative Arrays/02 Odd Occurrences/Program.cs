using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split()
                .ToList();

            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string toLower = word.ToLower();
                if (!occurences.ContainsKey(toLower))
                {
                    occurences[toLower] = 0;
                }
                occurences[toLower]++;
            }

            var final = occurences.Where(x => x.Value % 2 != 0);

            foreach (var word in final)
            {
                Console.Write(word.Key + " ");
            }
            Console.WriteLine();
        }
    }
}
