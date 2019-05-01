﻿using System;
using System.Linq;

namespace _08_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxNumber = 0;
            int maxCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        counter++;
                    }
                }
                if (counter>maxCounter)
                {
                    maxCounter = counter;
                    maxNumber = arr[i];
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
