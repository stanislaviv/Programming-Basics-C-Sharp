using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race_Условие
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var track_type = Console.ReadLine();

            var organization_costs_percent = 0.05;
            var price_junior = 0.0;
            var price_senior = 0.0;
            var participants_total = juniors + seniors;

            switch (track_type)
            {
                case "trail":
                    price_junior = 5.50;
                    price_senior = 7;
                    break;

                case "cross-country":
                    price_junior = 8;
                    price_senior = 9.5;

                    if (participants_total >= 50)
                    {
                        price_junior -= price_junior * 0.25;
                        price_senior -= price_senior * 0.25;
                    }
                    break;

                case "downhill":
                    price_junior = 12.25;
                    price_senior = 13.75;
                    break;

                case "road":
                    price_junior = 20;
                    price_senior = 21.50;
                    break;
            }

            var total_amount = juniors * price_junior + seniors * price_senior;
            var organizational_costs = total_amount * organization_costs_percent;
            var final_amount = total_amount - organizational_costs;

            Console.WriteLine($"{final_amount:f2}");


        }
    }
}