using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSurface
{
    class SquareSurface
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first side: ");
            var FirstSide = 
                decimal.Parse(Console.ReadLine());
            Console.Write("Enter Second Side: ");
            var SecondSide = 
                decimal.Parse(Console.ReadLine());

            var Area = FirstSide * SecondSide;

            Console.Write("Area is: ");
            Console.WriteLine(Area);

            
        }
    }
}
