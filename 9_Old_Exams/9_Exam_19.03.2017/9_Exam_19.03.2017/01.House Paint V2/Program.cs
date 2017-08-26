using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Paint_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = double.Parse(Console.ReadLine());

            var back_wall_area = x * x;
            var door_area = 1.2 * 2;
            var front_wall_area = back_wall_area - door_area;

            var window = 1.5 * 1.5;
            var side_walls = 2 * (x * y - window);
            var green_area = back_wall_area + front_wall_area + side_walls;

            var roof_side_walls = 2 * (x * y);
            var roof_triangles = 2 * (x * z / 2);
            var red_area = roof_side_walls + roof_triangles;

            var green_paint = green_area / 3.4;
            var red_paint = red_area / 4.3;

            Console.WriteLine($"{green_paint:f2}");
            Console.WriteLine($"{red_paint:f2}");
        }
    }
}
