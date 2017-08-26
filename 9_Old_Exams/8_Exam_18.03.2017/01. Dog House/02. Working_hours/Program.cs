using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Working_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours_needed = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var working_days = int.Parse(Console.ReadLine());

            var actual_hours = workers * working_days * 8;
            

            var difference = Math.Abs(hours_needed - actual_hours);
            var penalties = difference * working_days;

            if (actual_hours>=hours_needed)
            {
                Console.WriteLine("{0} hours legft",difference);
            }
            else
            {
                Console.WriteLine("{0} overtime",difference);
                Console.WriteLine("Penalties: {0}",penalties);
            }

        }
    }
}
