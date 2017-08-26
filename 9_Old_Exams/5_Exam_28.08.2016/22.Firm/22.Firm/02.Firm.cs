using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours_needed = int.Parse(Console.ReadLine());
            var days_available_total = int.Parse(Console.ReadLine());
            var overtime_workers = int.Parse(Console.ReadLine());

            var time_available_trianing_deducted = days_available_total * 0.9 * 8;
            var overtime = overtime_workers * 2 * days_available_total;
            var project_hours = Math.Floor(time_available_trianing_deducted + overtime);
            var difference = Math.Abs(project_hours - hours_needed);

            if (project_hours >= hours_needed)
            {
                Console.WriteLine($"Yes!{difference} hours left.");
            }

            else
            {
                Console.WriteLine($"Not enough time!{difference} hours needed.");
            }


        }
    }
}
