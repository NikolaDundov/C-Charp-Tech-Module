using System;
using System.Linq;

namespace _05_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] first = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char [] second = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int minLength = Math.Min(first.Length, second.Length);


            for (int i = 0; i < minLength; i++)
            {

                if (first[i] < second[i])
                {
                    Console.WriteLine(string.Join ("", first));
                    Console.WriteLine(string.Join("", second));
                    break;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine(string.Join("", second));
                    Console.WriteLine(string.Join("", first));
                    break;
                }
                else if (first[i]==second[i])
                {
                    if (first.Length==minLength)
                    {
                        Console.WriteLine(string.Join("", first));
                        Console.WriteLine(string.Join("", second));
                        break;
                    }
                    else if (second.Length == minLength)
                    {
                        Console.WriteLine(string.Join("", second));
                        Console.WriteLine(string.Join("", first));
                        break;
                    }
                    else if (first.Length==second.Length)
                    {
                        Console.WriteLine(string.Join("", second));
                        Console.WriteLine(string.Join("", first));
                        break;
                    }
                }
            }

            

        }
    }
}
