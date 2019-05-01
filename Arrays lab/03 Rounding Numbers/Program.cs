using System;
using System.Linq;

namespace _03_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] finalNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                finalNumbers[i] = (int) Math.Round( numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {finalNumbers[i]}");
            }
        }
    }
}
