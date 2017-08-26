using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time_plus_15_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var mins = int.Parse(Console.ReadLine());
            var mins_plus_15 = mins + 15;

            if (mins_plus_15 >= 60)
            {
                hours = (hours + 1) % 24;
                mins_plus_15 -= 60;
                Console.WriteLine($"{hours}{":"}{mins_plus_15:00}");
            }
            else
            {
                Console.WriteLine($"{hours}{":"}{mins_plus_15:00}");
            }

        }
    }
}
