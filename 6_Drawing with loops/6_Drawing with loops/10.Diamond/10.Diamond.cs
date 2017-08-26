using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int stars_in_top;

            if (n==1)
            {
                Console.WriteLine("*");
                return;
            }
            else if (n==2)
            {
                Console.WriteLine(new string('*',2));
                return;
            }

            if (n % 2 == 1)
            {
                stars_in_top = 1;
            }
            else
            {
                stars_in_top = 2;
            }
            var dashes_in_top = (n - stars_in_top) / 2;

            Console.WriteLine($"{new string('-', dashes_in_top)}{new string('*', stars_in_top)}{new string('-', dashes_in_top)}");

            int dashes_between_stars;

            if (n % 2 == 1)
            {
                dashes_between_stars = 1;
            }

            else
            {
                dashes_between_stars = 2;
            }


            var upper_part_height = (n - 1) / 2;
            for (int i = 0; i < upper_part_height; i++)
            {
                Console.Write(new string('-', dashes_in_top - 1));
                Console.Write("*");
                Console.Write(new string('-', dashes_between_stars));
                Console.Write("*");
                Console.Write(new string('-', dashes_in_top - 1));
                Console.WriteLine();
                dashes_between_stars += 2;
                dashes_in_top--;

            }

            for (int i = 0; i < upper_part_height-1; i++)
            {
                Console.Write(new string('-', 1 + i));
                Console.Write("*");
                Console.Write(new string('-',n-4-2*i));
                Console.Write("*");
                Console.Write(new string('-', 1 + i));
                Console.WriteLine();
            }

            Console.Write(new string('-',(n-stars_in_top)/2));
            Console.Write(new string('*',stars_in_top));
            Console.Write(new string('-', (n - stars_in_top) / 2));


        }
    }
}
