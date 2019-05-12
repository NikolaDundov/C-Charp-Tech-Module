using System;
using System.Linq;
using System.Collections.Generic;

namespace _01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            SortedDictionary <double, int> counts = new SortedDictionary <double, int>();

            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
