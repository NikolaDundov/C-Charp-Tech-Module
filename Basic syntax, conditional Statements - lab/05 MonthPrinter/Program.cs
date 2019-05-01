using System;

namespace _05_MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounth = int.Parse(Console.ReadLine());
            string word = string.Empty;

            switch (mounth)
            {
                case 1: word = "January"; break;
                case 2: word = "February"; break;
                case 3: word = "March"; break;
                case 4: word = "April"; break;
                case 5: word = "May"; break;
                case 6: word = "June"; break;
                case 7: word = "July"; break;
                case 8: word = "August"; break;
                case 9: word = "September"; break;
                case 10: word = "October"; break;
                case 11: word = "November"; break;
                case 12: word = "December"; break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            if (mounth<=12)
            {
                Console.WriteLine(word);
            }
        }
    }
}
