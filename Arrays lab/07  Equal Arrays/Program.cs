using System;
using System.Collections.Generic;
using System.Linq;

namespace _07__Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int index = 0;
            bool different = false;

            for (int i = 0; i < second.Count; i++)
            {
                if (first[i]==second[i])
                {
                    sum += first[i];
                }
                else
                {
                    index = i;
                    different = true;
                    break;
                }
            }
            if (different==false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
