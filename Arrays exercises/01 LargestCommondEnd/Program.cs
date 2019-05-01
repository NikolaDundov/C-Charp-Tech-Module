using System;
using System.Linq;

namespace _01_LargestCommondEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split();

            int counterLeft = 0;
            int counterRight = 0;
            int minLength = Math.Min(firstArr.Length, secondArr.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    counterLeft++;
                }
                if (firstArr[firstArr.Length-1-i]==secondArr[secondArr.Length-1-i])
                {
                    counterRight++;
                }

            }
                             
                Console.WriteLine(Math.Max(counterLeft, counterRight)); 
        }
    }
}
