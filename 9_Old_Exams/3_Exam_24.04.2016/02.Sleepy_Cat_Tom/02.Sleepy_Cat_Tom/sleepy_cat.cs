using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sleepy_Cat_Tom
{
    class sleepy_cat
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int workdays = 365 - holidays;
            var playtime_work = 63;
            var playtime_holiday = 127;
            var norm = 30000;
            var total_playtime = holidays * playtime_holiday + (365 - holidays) * playtime_work;
            var overplay = total_playtime - norm;
            var hours_over = overplay / 60;
            var mins_over = overplay % 60;
            var lessplay = norm - total_playtime;
            var hours_less = lessplay / 60;
            var mins_less = lessplay % 60;

            if (total_playtime < norm)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours_less} hours and {mins_less} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours_over} hours and {mins_over} minutes more for play");
            }





        }
    }
}
