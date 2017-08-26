using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var vineyard_area = int.Parse(Console.ReadLine());
            var kg_grapes_per_1sqm = double.Parse(Console.ReadLine());
            var ltr_for_sale = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var area_wine = vineyard_area * 0.4;
            var kg_harvest = area_wine * kg_grapes_per_1sqm;
            var ltr_wine_produced = kg_harvest / 2.5;
            var difference = Math.Floor(Math.Abs(ltr_wine_produced - ltr_for_sale));
            var wine_remaining = Math.Ceiling(ltr_wine_produced - ltr_for_sale);
            var wine_per_worker = Math.Ceiling(wine_remaining / workers);
            var ltr_wine_produced2 = Math.Floor(kg_harvest / 2.5);

            if (ltr_wine_produced < ltr_for_sale)
            {
                Console.WriteLine($"It will be a tough winter! More {difference} liters wine needed.");

            }
            else if (ltr_wine_produced >= ltr_for_sale)
            {
                Console.WriteLine($"Good harvest this year! Total wine: { ltr_wine_produced2} liters.");
                Console.WriteLine($"{wine_remaining} liters left -> {wine_per_worker} liters per person.");
            }
        }
    }
}
