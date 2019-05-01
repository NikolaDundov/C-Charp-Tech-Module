using System;
using System.Linq;

namespace _04_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] primaryArr = Console.ReadLine().Split().ToArray();
            string[] result = new string[primaryArr.Length];

            for (int i = primaryArr.Length - 1; i >= 0; i--)
            {
                result[primaryArr.Length - 1 - i] = primaryArr[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
