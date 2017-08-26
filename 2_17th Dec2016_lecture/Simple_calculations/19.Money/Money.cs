using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var uans = double.Parse(Console.ReadLine());
            var commision_rate = double.Parse(Console.ReadLine());

            var bitcoins_to_BGN = bitcoins * 1168;
            var uans_to_BGN = uans * 0.15 * 1.76;
            var total_EUR = (bitcoins_to_BGN + uans_to_BGN) / 1.95;
            var commission_amount = total_EUR * commision_rate / 100;
            var rezult = total_EUR - commission_amount;

            Console.WriteLine(rezult);

 
        

            
        }
    }
}
