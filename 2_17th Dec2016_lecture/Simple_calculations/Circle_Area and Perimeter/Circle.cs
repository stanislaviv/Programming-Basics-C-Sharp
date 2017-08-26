using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    class Circle
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}
