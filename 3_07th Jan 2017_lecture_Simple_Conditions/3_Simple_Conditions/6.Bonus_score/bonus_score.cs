using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Bonus_score
{
    class bonus_score
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            double bonus;
           


            if (num <= 100)
            {
                bonus = 5;
                
            }

            else if (num > 1000)
            {
                bonus = num * 0.1;
            }
            else
            {
                bonus = num * 0.2;
            }

            if (num % 2 == 0)
            {
                bonus += 1;
            }

            else if (num % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus+num);
          
        }
    }
}
