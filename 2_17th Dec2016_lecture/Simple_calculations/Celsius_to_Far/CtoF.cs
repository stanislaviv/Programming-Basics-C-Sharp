using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Far
{
    class CtoF
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());
            var F = C * 9 / 5 + 32;

            Console.WriteLine(F);
        }
    }
}
