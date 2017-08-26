using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());
            int car = 0;
            int bus = 0;
            int coach = 0;
            int bigcoach = 0;
            int train = 0;
            var TotalPeople = 0.0;

            for (int i = 1; i <= groups; i++)
            {
                int currentPeople = int.Parse(Console.ReadLine());

                if (currentPeople <= 5)
                {
                    car += currentPeople;
                }
                else if (currentPeople >= 6 && currentPeople <= 12)
                {
                    bus += currentPeople;
                }
                else if (currentPeople >= 13 && currentPeople <= 25)
                {
                    coach += currentPeople;
                }
                else if (currentPeople >= 26 && currentPeople <= 40)
                {
                    bigcoach += currentPeople;
                }
                else
                {
                    train += currentPeople;
                }

                TotalPeople += currentPeople;
            }

            Console.WriteLine($"{car / TotalPeople * 100:f2}%");
            Console.WriteLine($"{bus / TotalPeople * 100:f2}%");
            Console.WriteLine($"{coach / TotalPeople * 100:f2}%");
            Console.WriteLine($"{bigcoach / TotalPeople * 100:f2}%");
            Console.WriteLine($"{train / TotalPeople * 100:f2}%");
          

        }
    }
}
