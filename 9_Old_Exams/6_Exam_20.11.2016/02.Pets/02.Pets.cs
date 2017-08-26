using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var available_food = int.Parse(Console.ReadLine());
            var dog_food_kg = double.Parse(Console.ReadLine());
            var cat_foo_kg = double.Parse(Console.ReadLine());
            var turtle_food_grams = double.Parse(Console.ReadLine());

            var turtle_food_kg = turtle_food_grams / 1000;
            var total_food_needed = days*(dog_food_kg + cat_foo_kg + turtle_food_kg);
            var diffrence = Math.Abs(available_food - total_food_needed);

            if (available_food >= total_food_needed)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(diffrence));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(diffrence));


            }



        }
    }
}
