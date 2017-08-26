using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            var people_nr = int.Parse(Console.ReadLine());

            var VIP = 499.99;
            var Normal = 249.99;
            double transport_cost;
            var VIP_price = VIP * people_nr;
            var Normal_Price = Normal * people_nr;

            if (type=="vip")
            {
                if (people_nr >= 1 && people_nr <= 4)
                {
                    if (budget*0.25>=VIP_price)
                    {
                        Console.WriteLine($"Yes! You have {budget*0.25-VIP_price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {VIP_price - budget * 0.25:f2} leva.");
                    }
                }
                else if (people_nr >= 5 && people_nr <= 9)
                {
                    if (budget * 0.4 >= VIP_price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.4 - VIP_price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {VIP_price - budget * 0.4:f2} leva.");
                    }
                }
                else if (people_nr >= 10 && people_nr <= 24)
                {
                    if (budget * 0.5 >= VIP_price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.5 - VIP_price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {VIP_price - budget * 0.5:f2} leva.");
                    }
                }
                else if (people_nr >= 25 && people_nr <= 49)
                {
                    if (budget * 0.6 >= VIP_price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.6 - VIP_price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {VIP_price - budget * 0.6:f2} leva.");
                    }
                }
                else
                {
                    if (budget * 0.75 >= VIP_price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.75 - VIP_price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {VIP_price - budget * 0.75:f2} leva.");
                    }
                }
            }
            else
            {
                if (people_nr >= 1 && people_nr <= 4)
                {
                    if (budget * 0.25 >= Normal_Price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.25 - Normal_Price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {Normal_Price - budget * 0.25:f2} leva.");
                    }
                }
                else if (people_nr >= 5 && people_nr <= 9)
                {
                    if (budget * 0.4 >= Normal_Price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.4 - Normal_Price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {Normal_Price - budget * 0.4:f2} leva.");
                    }
                }
                else if (people_nr >= 10 && people_nr <= 24)
                {
                    if (budget * 0.5 >= Normal_Price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.5 - Normal_Price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {Normal_Price - budget * 0.5:f2} leva.");
                    }
                }
                else if (people_nr >= 25 && people_nr <= 49)
                {
                    if (budget * 0.6 >= Normal_Price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.6 - Normal_Price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {Normal_Price - budget * 0.6:f2} leva.");
                    }
                }
                else
                {
                    if (budget * 0.75 >= Normal_Price)
                    {
                        Console.WriteLine($"Yes! You have {budget * 0.75 - Normal_Price:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {Normal_Price - budget * 0.75:f2} leva.");
                    }
                }
            }


        }
    }
}
