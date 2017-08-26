using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var nr_loads = int.Parse(Console.ReadLine());

            int bus = 0;
            int truck = 0;
            int train = 0;
            double total_tons = 0.0;

            for (int i = 1; i <= nr_loads; i++)
            {
                var current_load = int.Parse(Console.ReadLine());
                if (current_load<=3)
                {
                    bus += current_load;
                }
                else if (current_load>=4 && current_load<=11)
                {
                    truck += current_load;
                }
                else
                {
                    train += current_load;
                }
                total_tons += current_load;
            }
            var total_price = bus * 200 + truck * 175 + train * 120;
            var average_price = total_price / total_tons;
            Console.WriteLine($"{average_price:f2}");
            Console.WriteLine($"{bus/total_tons*100:f2}%");
            Console.WriteLine($"{truck / total_tons*100:f2}%");
            Console.WriteLine($"{train / total_tons*100:f2}%");



        }
    }
}
