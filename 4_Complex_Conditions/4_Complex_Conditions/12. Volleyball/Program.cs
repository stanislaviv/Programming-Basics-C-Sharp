using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year_type = Console.ReadLine();
            var holidays = double.Parse(Console.ReadLine());
            var travelling_home = double.Parse(Console.ReadLine());
            var volleyball_weekends = 48;

            var Sofia_weekends = volleyball_weekends - travelling_home;
            var games_home_town = travelling_home;
            double games_bank_holidays = holidays * 2 / 3;
            double games_Sofia = Sofia_weekends * 3 / 4;
            double total_games = games_Sofia + games_bank_holidays + games_home_town;
            double additional_games = total_games * 0.15;
            double leap_year_games = total_games + additional_games;

            if (year_type=="normal")
            {
         
                Console.WriteLine(Math.Floor(total_games));
            }
            else
            {
               
                Console.WriteLine(Math.Floor(leap_year_games));
            }
        }
    }
}
