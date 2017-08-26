using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var price = -1.0;

            if (day=="monday"||day=="tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit=="banana")
                {
                    price = 2.50 * quantity;
                }
                else if (fruit=="apple")
                {
                    price = 1.2 * quantity;
                }
                else if (fruit=="orange")
                {
                    price = 0.85 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50 * quantity;
                }

                else if (fruit == "grapes")
                {
                    price = 3.85 * quantity;
                }
                else
                {
                    price += price;
                }
            }
            else if (day=="saturday"||day=="sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70 * quantity;
                }
                else if (fruit == "apple")
                {
                    price = 1.25 * quantity;
                }
                else if (fruit == "orange")
                {
                    price = 0.90 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    price = 3 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60 * quantity;
                }

                else if (fruit == "grapes")
                {
                    price = 4.2 * quantity;
                }
                else
                {
                    price += price;
                }
                
            }
            else
            {
                price += price;
            }

            if (price<0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
