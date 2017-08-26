using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var working_days = int.Parse(Console.ReadLine());
            var money_per_day = double.Parse(Console.ReadLine());
            var RoE = double.Parse(Console.ReadLine());

            var monthly_income = money_per_day * working_days;
            var bonus = monthly_income * 2.5;
            var annual_income_before_tax = 12 * monthly_income + bonus;
            var tax = annual_income_before_tax * 0.25;
            var net_annual_income = annual_income_before_tax - tax;
            var avr_daily_income = Math.Round(net_annual_income / 365 * RoE, 2);

            Console.WriteLine(avr_daily_income);


        }
    }
}
