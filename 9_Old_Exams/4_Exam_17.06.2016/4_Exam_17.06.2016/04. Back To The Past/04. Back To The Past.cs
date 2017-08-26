using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var inheritance = double.Parse(Console.ReadLine());
            var final_year = int.Parse(Console.ReadLine());
            var odd_budget = 0.0;
            var even_budget = 0.0;
            var age = 18;

            for (int i = 1800; i <= final_year; i++)
            {
                
                if (i % 2 == 0)
                {
                    even_budget += 12000;
                }
                else
                {
                    
                    odd_budget += 12000 + age * 50;
                }
                age += 1;
            }
            var total_needed = odd_budget + even_budget;

            if (inheritance>=total_needed)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance-total_needed:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {total_needed-inheritance:f2} dollars to survive.");
            }
        }
    }
}
