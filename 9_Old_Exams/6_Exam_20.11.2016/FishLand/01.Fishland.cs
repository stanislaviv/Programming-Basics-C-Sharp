using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumria_price = double.Parse(Console.ReadLine());
            var caca_price = double.Parse(Console.ReadLine());
            var palamud_kg = double.Parse(Console.ReadLine());
            var safrid_kg = double.Parse(Console.ReadLine());
            var midi_kg = double.Parse(Console.ReadLine());

            var palamud_price = skumria_price * 1.6;
            var safrid_price = caca_price * 1.8;    

            var total_price = palamud_kg * palamud_price + safrid_kg * safrid_price + midi_kg * 7.5;
            Console.WriteLine($"{total_price:f2}");





        }
    }
}
