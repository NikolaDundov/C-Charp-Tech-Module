using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
