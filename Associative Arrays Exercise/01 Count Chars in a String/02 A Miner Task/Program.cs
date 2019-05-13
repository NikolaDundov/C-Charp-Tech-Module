using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (result.ContainsKey(resource))
                {
                    result[resource] += quantity;
                }
                else
                {
                    result[resource] = quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
