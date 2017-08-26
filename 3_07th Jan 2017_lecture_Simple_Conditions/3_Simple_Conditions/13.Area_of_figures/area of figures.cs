using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            double area;

            if (figure == "square")
            {
                var square_side = double.Parse(Console.ReadLine());
                area = square_side * square_side;
             
            }
            else if (figure == "rectangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                area = side1 * side2;
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                area = radius * Math.PI * radius;
            }
            else
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                area = side * height / 2;             
            }
            Console.WriteLine(area);






        }
    }
}
