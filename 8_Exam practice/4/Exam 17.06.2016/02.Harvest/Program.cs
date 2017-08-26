using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = int.Parse(Console.ReadLine());
            var grapes_per_sq_m = double.Parse(Console.ReadLine());
            var needed_amount = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var area_production = 0.4 * area;
            var kg_grapes = area_production * grapes_per_sq_m;
            var wine_produced = kg_grapes / 2.5;

            if (wine_produced < needed_amount)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needed_amount - wine_produced)} litres wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(wine_produced)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine_produced - needed_amount)} litres left -> {Math.Ceiling((wine_produced - needed_amount) / workers)} liters per person.");
            }


        }
    }
}
