using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnoli = int.Parse(Console.ReadLine());
            var zumbuli = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var kaktusi = int.Parse(Console.ReadLine());
            var present_price = double.Parse(Console.ReadLine());

            var pechalba_before_tax = magnoli * 3.25 + zumbuli * 4 + rozi * 3.5 + kaktusi * 8;
            var tax = pechalba_before_tax * 0.05;
            var net_profit = pechalba_before_tax - tax;
            var difference = Math.Abs(net_profit - present_price);

            if (pechalba_before_tax >= present_price)
            {
                Console.WriteLine("She is left with {0} leva.",Math.Floor(difference));
            }

            else
            {
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(difference));
            }




        }
    }
}
