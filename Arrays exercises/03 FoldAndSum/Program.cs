using System;
using System.Linq;

namespace _03_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] foldedRight = new int[input.Length / 4];

            for (int i = 0; i < foldedRight.Length; i++)
            {
                foldedRight[i] = input[input.Length - 1 - i];
            }

            int[] foldedLeft = new int[input.Length / 4];

            for (int i = 0; i < foldedLeft.Length; i++)
            {
                foldedLeft[i] = input[input.Length / 4 - i - 1];
            }

            int[] arrConcatenate = foldedLeft.Concat(foldedRight).ToArray();

            int[] left = new int[input.Length / 2];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = input[input.Length / 4 + i];
            }

            int[] sum = new int[left.Length];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = arrConcatenate[i] + left[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
