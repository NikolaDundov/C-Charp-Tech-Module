using System;

namespace _06_Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = "";

            if (country == "USA" || country == "England")
            {
                language = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                language = "Spanish";
            }
            else
            {
                Console.WriteLine("unknown");
            }
            if (language.Length > 0)
            {
                Console.WriteLine(language);

            }
        }
    }
}
