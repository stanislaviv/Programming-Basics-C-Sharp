using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Glasses
{
    class Glasses
    {
        static void Main(string[] args)
        {
            var glasses_target = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var work_days = double.Parse(Console.ReadLine());

            var total_actual_hours = workers * work_days * 8;
            var glasses_produced = Math.Floor(total_actual_hours / 5);

            if (glasses_produced >= glasses_target)
            {
                Console.WriteLine($"{(glasses_produced-glasses_target)*4.2:f2} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {(glasses_target - glasses_produced) * 4.2:f2}");
            }
        }
    }
}
