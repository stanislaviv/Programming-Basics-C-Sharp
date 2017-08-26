using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var uans = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var bitcoins_to_leva = bitcoins * 1168;
            var uans_to_leva = uans * 0.15 * 1.76;
            var total_leva = bitcoins_to_leva + uans_to_leva;
            var total_eur = total_leva / 1.95;
            var commission_amount = total_eur * commission / 100;
            var final_amount_EUR = total_eur - commission_amount;


            //Console.WriteLine(bitcoins_to_leva);
            //Console.WriteLine(uans_to_leva);
            //Console.WriteLine(total_leva);
            //Console.WriteLine(total_eur);
            //Console.WriteLine(commission_amount);
            Console.WriteLine(final_amount_EUR);
        }
    }
}
