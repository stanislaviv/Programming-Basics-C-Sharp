using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults_nr = int.Parse(Console.ReadLine());
            var students_nr = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport_type = Console.ReadLine().ToLower();
            var nights_price = nights * 82.99;


            var group_total = adults_nr + students_nr;
            double discount = 0;
            double adult_price = 0;
            double student_price = 0;


            switch (transport_type)
            {
                case "train":
                    adult_price = 24.99;
                    student_price = 14.99;
                    if ((adults_nr+students_nr)>=50)
                    {
                        discount = 0.5;
                    }
                    else
                    {
                        discount = 0.0;
                    }
                    break;
                case "bus":
                    adult_price = 32.50;
                    student_price = 28.50;
                    break;
                case "boat":
                    adult_price = 42.99;
                    student_price = 39.99;
                    break;

                case "airplane":
                    adult_price = 70.00;
                    student_price = 50.00;
                    break;



            }
            var transport_price = (adults_nr * adult_price + students_nr * student_price)*2;
            var discount_amount = transport_price * discount;
            var transport_price_discaount = transport_price - discount_amount;
            var commission_amount = (transport_price_discaount + nights_price) * 0.1;
            var final_amount = transport_price_discaount + commission_amount + nights_price;

            Console.WriteLine($"{final_amount:f2}");
 

        }
    }
}
