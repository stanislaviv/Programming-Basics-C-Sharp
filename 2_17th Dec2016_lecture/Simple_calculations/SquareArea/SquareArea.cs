using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            var squareside = int.Parse(Console.ReadLine());
            var area = squareside * squareside;

            //Console.WriteLine("Area is " + area);
            //Console.WriteLine("Area is {0}",area );
            Console.WriteLine($"Area is {area}");

        }
    }
}
