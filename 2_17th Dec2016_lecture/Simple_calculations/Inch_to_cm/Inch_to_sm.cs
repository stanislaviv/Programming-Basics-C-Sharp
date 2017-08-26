using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inch_to_cm
{
    class Inch_to_sm
    {
        static void Main(string[] args)
        {
            Console.Write("Input Inches to Convert ");
            var inches = double.Parse(Console.ReadLine());
            var cm = inches * 2.54;
            Console.WriteLine($"Distance in cm is {cm}");


        }
    }
}
