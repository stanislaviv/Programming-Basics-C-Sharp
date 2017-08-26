using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Car_Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();


            if (budget <= 100)
            {
                string car_class = "Economy class";

                if (season == "summer")
                {
                    string car_type = "Cabrio";
                    var price = budget * 0.35;
                    Console.WriteLine(car_class);
                    Console.Write(car_type);
                    Console.WriteLine($" - {price:f2}");
                }
                else
                {
                    string car_type = "Jeep";
                    var price = budget * 0.65;
                    Console.WriteLine(car_class);
                    Console.Write(car_type);
                    Console.WriteLine($" - {price:f2}");
                }

            }
            else if (budget > 100 && budget <= 500)
            {
                string car_class = "Compact class";
                if (season == "summer")
                {
                    string car_type = "Cabrio";
                    var price = budget * 0.45;
                    Console.WriteLine(car_class);
                    Console.Write(car_type);
                    Console.WriteLine($" - {price:f2}");
                }
                else
                {
                    string car_type = "Jeep";
                    var price = budget * 0.80;
                    Console.WriteLine(car_class);
                    Console.Write(car_type);
                    Console.WriteLine($" - {price:f2}");
                }
            }

            else
            {
                string car_class = "Luxury class";
                string car_type = "Jeep";
                var price = budget * 0.90;
                Console.WriteLine(car_class);
                Console.Write(car_type);
                Console.WriteLine($" - {price:f2}");
            }


            




        }
    }
}
