using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class rectangle_area
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double area = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
            double perimeter = 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
            Console.WriteLine(area);
            Console.WriteLine(perimeter);


        }
    }
}
