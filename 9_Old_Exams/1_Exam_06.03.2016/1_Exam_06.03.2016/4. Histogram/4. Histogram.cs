using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers_inputed = int.Parse(Console.ReadLine());
            var less_200 = 0.0;
            var second_interval = 0.0;
            var third_interval = 0.0;
            var fourth_interval = 0.0;
            var last_interval = 0.0;


            for (int i = 0; i < numbers_inputed; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    less_200++;
                }
                else if (number >= 200 && number <= 399)
                {
                    second_interval++;
                }
                else if (number >= 400 && number <= 599)
                {
                    third_interval++;
                }
                else if (number >= 600 && number <= 799)
                {
                    fourth_interval++;
                }
                else
                {
                    last_interval++;
                }

            }
            var p1 = less_200 / numbers_inputed * 100;
            var p2 = second_interval / numbers_inputed * 100;
            var p3 = third_interval / numbers_inputed * 100;
            var p4 = fourth_interval / numbers_inputed * 100;
            var p5 = last_interval / numbers_inputed * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
          
        }
    }
}
