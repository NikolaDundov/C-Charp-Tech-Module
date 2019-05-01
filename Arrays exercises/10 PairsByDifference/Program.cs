using System;
using System.Linq;

namespace _10_PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {

                    if (Math.Abs(numbers[j]-numbers[i]) == n)
                    {
                        counter++;
                    }

                }

            }
            Console.WriteLine(counter);

        }
    }
}
