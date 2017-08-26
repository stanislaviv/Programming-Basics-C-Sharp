using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Division_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers_count = int.Parse(Console.ReadLine());
            var divided_2 = 0.0;
            var divided_3 = 0.0;
            var divided_4 = 0.0;

            for (int i = 0; i < numbers_count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    divided_2++;
                }

                if (number % 3 == 0)
                {
                    divided_3++;
                }

                if (number % 4 == 0)
                {
                    divided_4++;
                }
            }
            var p1 = divided_2 / numbers_count * 100;
            var p2 = divided_3 / numbers_count * 100;
            var p3 = divided_4 / numbers_count * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
