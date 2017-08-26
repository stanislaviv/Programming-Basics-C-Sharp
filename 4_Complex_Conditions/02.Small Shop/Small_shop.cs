using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Small_shop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());


            if (city == "sofia")
            {
                if (product=="coffee")
                {
                    Console.WriteLine(0.5*quantity);
                }
                else if (product=="water")
                {
                    Console.WriteLine(quantity*0.8);
                }
                else if (product=="beer")
                {
                    Console.WriteLine(quantity*1.2);
                }
                else if (product=="sweets")
                {
                    Console.WriteLine(quantity*1.45);
                }
                else
                {
                    Console.WriteLine(quantity*1.6);
                }
            }
            else if(city=="plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.4 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else
                {
                    Console.WriteLine(quantity * 1.50);
                }
            }
            else
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                else
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
        }
    }
}