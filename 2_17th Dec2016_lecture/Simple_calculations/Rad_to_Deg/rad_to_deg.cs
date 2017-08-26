using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_to_Deg
{
    class rad_to_deg
    {
        static void Main(string[] args)
        {
            var R = double.Parse(Console.ReadLine());
            var deg = Math.Round(R * 180 / Math.PI, 0);

            Console.WriteLine(deg);

        }
    }
}
