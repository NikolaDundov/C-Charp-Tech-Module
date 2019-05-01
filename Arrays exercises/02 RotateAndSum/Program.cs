using System;
using System.Linq;

namespace _02_RotateAndSum
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int[] sumArr = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                Shift(numbers);
                Sum(sumArr, numbers);
            }
            
            Console.WriteLine(string.Join(" ", sumArr));
        }

        private static void Shift(int[] numbers)
        {
            int last = numbers[numbers.Length - 1];

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }
            numbers[0] = last;
        }
        static void Sum (int [] Sum, int [] numbers)
        {
            for (int i = 0; i < Sum.Length; i++)
            {
                Sum[i] += numbers[i];
            }
        }
    }
}
