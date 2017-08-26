using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
          

            var seats_nr = rows * columns;
 

            if (type=="premiere")
            {
                var price = 12;
                var revenue = seats_nr * price;
                Console.WriteLine($"{revenue:f2}");
            }
            else if (type=="normal")
            {
                var price = 7.5;
                var revenue = seats_nr * price;
                Console.WriteLine($"{revenue:f2}");


            }
            else
            {
                var price = 5;
                var revenue = seats_nr * price;
                Console.WriteLine($"{revenue:f2}");

            }
          
      
        }
    }
}
