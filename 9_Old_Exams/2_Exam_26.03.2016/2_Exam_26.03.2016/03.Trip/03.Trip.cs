using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            var price_summer_under_100 = 0.3 * budget;
            var price_winter_under_100 = 0.7 * budget;
            var price_summer_less_1000 = 0.4 * budget;
            var price_winter_less_1000 = 0.8 * budget;
            var price_1000 = 0.9 * budget;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {price_summer_under_100:f2}");
                }
                else
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {price_winter_under_100:f2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {price_summer_less_1000:f2}");
                }
                else
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {price_winter_less_1000:f2}");
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {price_1000:f2}");
            }
          


        }
    }
}
