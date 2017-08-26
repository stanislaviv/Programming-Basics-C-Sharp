using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price
{
    class house_price
    {
        static void Main(string[] args)
        {
            var smallest_room = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price_per_sqm = double.Parse(Console.ReadLine());

            var bathroom = smallest_room / 2;
            var second_room = smallest_room * 1.1;
            var thirs_room = second_room * 1.1;
            var all_rooms = smallest_room + second_room + thirs_room + kitchen + bathroom;
            var hallway = all_rooms * 0.05;

            var price = (all_rooms + hallway) * price_per_sqm;
            Console.WriteLine($"{price:f2}");



        }
    }
}
