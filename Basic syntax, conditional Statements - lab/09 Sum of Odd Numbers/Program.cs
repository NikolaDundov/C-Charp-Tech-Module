using System;

namespace _09_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = -1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(num+=2);
                sum += num;

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
