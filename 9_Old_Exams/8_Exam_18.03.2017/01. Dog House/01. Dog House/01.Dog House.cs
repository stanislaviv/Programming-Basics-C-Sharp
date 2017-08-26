using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var roof_area = 2 * (lenght * lenght / 2);
            var red_paint = roof_area /5;

            var back_wall_area = (lenght / 2 * lenght / 2 + (lenght / 2 * (height - lenght / 2)) / 2);
            var door = (lenght / 5 * lenght / 5);
            var front_wall_area = back_wall_area - door;
            var side_walls_area = 2 * (lenght * lenght / 2);

            var walls_area = back_wall_area + front_wall_area + side_walls_area;
            var green_paint = (double)walls_area /3;

            Console.WriteLine($"{green_paint:f2}");
            Console.WriteLine($"{red_paint:f2}");

            Console.WriteLine(roof_area);
            Console.WriteLine(red_paint);
            Console.WriteLine(back_wall_area);
            Console.WriteLine(front_wall_area);
            Console.WriteLine(side_walls_area);
            Console.WriteLine(walls_area);
            Console.WriteLine(green_paint);
            Console.WriteLine(door);


        }
    }
}
