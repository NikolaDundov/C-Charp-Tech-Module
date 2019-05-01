using System;
using System.Linq;

namespace _08_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primary = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (primary.Length == 1)
            {
                Console.WriteLine(string.Join("", primary));
            }

            else
            {
                int[] condensed = new int[primary.Length - 1];

                while (condensed.Length > 1)
                {
                    condensed = new int[primary.Length - 1];

                    for (int i = 0; i < primary.Length - 1; i++)
                    {
                        condensed[i] = primary[i] + primary[i + 1];
                    }

                    primary = condensed;

                }

                Console.WriteLine(string.Join("", condensed));

            }

        }
    }
}
