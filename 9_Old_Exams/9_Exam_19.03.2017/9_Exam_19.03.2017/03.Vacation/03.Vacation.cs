using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            var price = 0.0;

            if (budget <= 1000)
            {
                if (season == "summer")
                {
                    price = budget * 0.65;
                    Console.Write("Alaska - ");
                    Console.Write("Camp - ");
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    price = budget * 0.45;
                    Console.Write("Morocco - ");
                    Console.Write("Camp - ");
                    Console.WriteLine($"{price:f2}");
                }
            }

            else if (budget > 1000 && budget <= 3000)
            {
                if (season == "summer")
                {
                    price = budget * 0.80;
                    Console.Write("Alaska - ");
                    Console.Write("Hut - ");
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    price = budget * 0.60;
                    Console.Write("Morocco - ");
                    Console.Write("Hut - ");
                    Console.WriteLine($"{price:f2}");

                }
            }
            else
            {
                price = budget * 0.90;
                if (season == "summer")
                {
                    Console.Write("Alaska - ");
                    Console.Write("Hotel - ");
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    Console.Write("Morocco - ");
                    Console.Write("Hotel - ");
                    Console.WriteLine($"{price:f2}");

                }
            }
        }
    }
}
