using System;
using System.Collections.Generic;
using System.Linq;

namespace _03__Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();

            result["fragments"] = 0;
            result["shards"] = 0;
            result["motes"] = 0;

            var junk = new SortedDictionary<string, int>();

            bool succeed = false;

            while (succeed == false)
            {
                var items = Console.ReadLine()
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < items.Length; i += 2)
                {
                    //3 Motes 5 stones 5 Shards
                    int quantity = int.Parse(items[i]);
                    string type = items[i + 1];

                    if (type == "fragments" || type == "shards" || type == "motes")
                    {
                        if (!result.ContainsKey(type))
                        {
                            result[type] = quantity;
                        }
                        else
                        {
                            result[type] += quantity;
                        }

                    }
                    else
                    {
                        if (!junk.ContainsKey(type))
                        {
                            junk[type] = 0;
                        }

                        junk[type] += quantity;
                    }

                    if (result["motes"] >= 250 || result["shards"] >= 250 || result["fragments"] >= 250)
                    {
                        result[type] -= 250;
                        if (type == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                        }
                        else if (type == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");

                        }
                        else if (type == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");

                        }
                        succeed = true;
                        break;
                    }
                }
            }


            foreach (var kvp in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
