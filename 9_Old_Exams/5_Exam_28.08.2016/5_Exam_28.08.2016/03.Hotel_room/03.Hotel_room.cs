using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());
           

            double studio_price=0;
            double apartment_price=0;

            switch (month)
            {
                case "may":
                case "october":
                    studio_price = 50;
                    apartment_price = 65;

                    if (nights > 14)
                    {
                        studio_price -= 50 * 0.3;
                        apartment_price -= 65 * 0.1;
                    }
                    else if (nights > 7)
                    {
                        studio_price -= 50 * 0.05;
                        
                    }
                    break;

                case "june":
                case "september":
                    studio_price = 75.20;
                    apartment_price = 68.70;


                    if (nights > 14)
                    {
                        studio_price -= 75.20 * 0.2;
                        apartment_price -= 68.70 * 0.1;
                    }
                    break;

                case "july":
                case "august":

                    studio_price = 76;
                    apartment_price = 77;

                    if (nights > 14)
                    {
                        apartment_price -= 77 * 0.1;
                    }
                    break;

            }

            double studio_total = nights * studio_price;
            double apartment_total = nights * apartment_price;

            Console.WriteLine($"Apartment: {apartment_total:f2} lv.");
            Console.WriteLine($"Studio: {studio_total:f2} lv.");

            

        }
    }
}

