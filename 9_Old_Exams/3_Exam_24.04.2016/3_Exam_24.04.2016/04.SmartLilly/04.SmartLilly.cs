using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lilly_age = int.Parse(Console.ReadLine());
            var WM_price = double.Parse(Console.ReadLine());
            var toy_price = int.Parse(Console.ReadLine());
            var bday_money = 10;
            var lilly_savings = 0;
            var money_toys = 0;


            for (int i = 1; i <= Lilly_age; i++)
            {
                if (i % 2 == 0)
                {
                    lilly_savings = lilly_savings + bday_money;
                    lilly_savings -= 1;
                    bday_money = bday_money + 10;
                  

                }
                else
                {
                    money_toys += toy_price;
                }
            }

            var all_savings = money_toys + lilly_savings;

            if (all_savings>=WM_price)
            {
                Console.WriteLine($"Yes! {all_savings-WM_price:f2}");
            }
            else
            {
                Console.WriteLine($"No! {WM_price-all_savings:f2}");
            }
         
        }
    }
}