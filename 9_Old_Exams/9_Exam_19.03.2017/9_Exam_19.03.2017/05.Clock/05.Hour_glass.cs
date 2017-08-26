using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var widht = 2 * n + 1;
            var height = 2 * n + 1;
            var dots_on_top = widht - 4;

            //upper 2 rows
            Console.WriteLine(new string('*', 2 * n + 1));
            Console.Write(".*");
            Console.Write(new string(' ', dots_on_top));
            Console.WriteLine("*.");

            //first half

            var first_half_height = n - 2;
            var dots_on_top_first_half = 2;
            var stars_on_top_first_half = 1;
            var monkey_first_half = (2 * n + 1) - 2 * (dots_on_top_first_half - stars_on_top_first_half) - 4;

            for (int i = 1; i <= first_half_height; i++)
            {
                Console.Write(new string('.', dots_on_top_first_half));
                Console.Write("*");
                Console.Write(new string('@', monkey_first_half));
                Console.Write("*");
                Console.WriteLine(new string('.', dots_on_top_first_half));

                dots_on_top_first_half++;
                monkey_first_half = monkey_first_half - 2;
            }

            //middle row
            Console.WriteLine("{0}{1}{0}", new string('.', n), "*");

            //second half
            var dots_second_half = n - 1;
            var second_half_height = n - 2;
            var dots_inside = 0;

            for (int i = 1; i <=second_half_height; i++)
            {
                Console.Write(new string('.', dots_second_half));
                Console.Write("*");
                Console.Write(new string(' ',dots_inside));
                Console.Write("@");
                Console.Write(new string(' ', dots_inside));
                Console.Write("*");
                Console.WriteLine(new string('.', dots_second_half));

                dots_second_half--;
                dots_inside++;


            }

            //bottom 2 rows
            Console.Write(".*");
            Console.Write(new string('@',2*n+1-4));
            Console.WriteLine("*.");
            Console.WriteLine(new string('*', 2 * n + 1));



        }
    }
}
