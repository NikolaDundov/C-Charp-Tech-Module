using System;
using System.Collections.Generic;
using System.Linq;

namespace _06__Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int current = numbers[i];

                if (current%2==0)
                {
                    evenSum += current;
                }
                else
                {
                    oddSum += current;
                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
