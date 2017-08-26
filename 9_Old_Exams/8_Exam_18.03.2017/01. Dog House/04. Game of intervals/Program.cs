using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Game_of_intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var moves = int.Parse(Console.ReadLine());

            var total_points = 0.0;
            var From_0_to_9 = 0.0;
            var From_10_to_19 = 0.0;
            var From_20_to_29 = 0.0;
            var From_30_to_39 = 0.0;
            var From_40_to_50 = 0.0;
            var invalid_number = 0.0;


            for (int i = 1; i <= moves; i++)
            {
                var current_number = int.Parse(Console.ReadLine());
                if (current_number >= 0 && current_number <= 9)
                {
                    total_points += current_number * 0.2;
                    From_0_to_9++;
                }
                else if (current_number >= 10 && current_number <= 19)
                {
                    total_points += current_number * 0.3;
                    From_10_to_19++;
                }
                else if (current_number >= 20 && current_number <= 29)
                {
                    total_points += current_number * 0.4;
                    From_20_to_29++;
                }
                else if (current_number >= 30 && current_number <= 39)
                {
                    total_points += 50;
                    From_30_to_39++;
                }
                else if (current_number >= 40 && current_number <= 50)
                {
                    total_points += 100;
                    From_40_to_50++;
                }
                else
                {
                    total_points = total_points / 2;
                    invalid_number++;
                }
            }

            Console.WriteLine($"{total_points:f2}");
            Console.WriteLine($"From 0 to 9: {(From_0_to_9/moves*100):f2}");
            Console.WriteLine($"From 10 to 19: {(From_10_to_19 / moves * 100):f2}%");
            Console.WriteLine($"From 20 to 29: {(From_20_to_29 / moves * 100):f2}%");
            Console.WriteLine($"From 30 to 39: {(From_30_to_39 / moves * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {(From_40_to_50 / moves * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {(invalid_number / moves * 100):f2}%");





        }
    }
}
