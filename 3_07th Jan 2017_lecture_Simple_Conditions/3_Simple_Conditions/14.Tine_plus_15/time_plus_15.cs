using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Tine_plus_15
{
    class time_plus_15
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            var total_time = (hour * 60) + min + 15;
            var new_hours = total_time / 60;


            if (new_hours == 24)
            {
                new_hours = 00;
            }
            Console.Write(new_hours);
            if (total_time % 60 < 9)
            {
                Console.WriteLine($"{":0"}{total_time % 60}");

            }
            else
                Console.WriteLine($"{":"}{total_time % 60}");





        }
    }
}
