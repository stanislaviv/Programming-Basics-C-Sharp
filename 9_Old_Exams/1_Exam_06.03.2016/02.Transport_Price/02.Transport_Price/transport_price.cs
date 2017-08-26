using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class transport_price
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double taxi_price;
            double bus_price;
            double train_price;
            double min_price;

            if ((km < 20) & (time == "day"))
            {
                min_price = 0.7 + km * 0.79;
            }
            else if ((km < 20) & (time == "night"))
            {
                min_price = 0.7 + km * 0.90;
            }
            else if ((km < 100) & (time == "day"))
            {
                taxi_price = 0.7 + km * 0.79;
                bus_price = km * 0.09;
                min_price = Math.Min(taxi_price, bus_price);
            }
            else if ((km < 100) & (time == "night"))
            {
                taxi_price = 0.7 + km * 0.90;
                bus_price = km * 0.09;
                min_price = Math.Min(taxi_price, bus_price);
            }
            else if ((km > 100) & (time == "day"))
            {
                taxi_price = 0.7 + km * 0.79;
                bus_price = km * 0.09;
                train_price = km * 0.06;
                min_price = Math.Min(train_price, bus_price);

            }
            else
            {
                taxi_price = 0.7 + km * 0.90;
                bus_price = km * 0.09;
                train_price = km * 0.06;
                min_price = Math.Min(train_price, bus_price);
            }

            Console.WriteLine(min_price);








        }
    }
}
