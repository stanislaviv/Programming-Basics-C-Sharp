using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Convertor
{
    class Convertor
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            string input_unit = Console.ReadLine().ToLower();
            string output_unit = Console.ReadLine().ToLower();

            if (input_unit == "mm")
            {
                distance = distance / 1000;
            }
            else if (input_unit == "cm")
            {
                distance = distance /100;
            }
            else if (input_unit == "mi")
            {
                distance = distance / 0.000621371192;
            }
            else if (input_unit == "in")
            {
                distance = distance / 39.3700787;
            }
            else if (input_unit == "km")
            {
                distance = distance * 1000;
            }
            else if (input_unit == "ft")
            {
                distance = distance / 3.2808399;
            }
            else if (input_unit == "yd")
            {
                distance = distance / 1.0936133;
            }
            else
            {
                distance = distance * 1;
            }

            if (output_unit == "mm")
            {
                distance = distance * 1000;
            }
            else if (output_unit == "cm")
            {
                distance = distance * 100;
            }
            else if (output_unit == "mi")
            {
                distance = distance * 0.000621371192;
            }
            else if (output_unit == "in")
            {
                distance = distance * 39.3700787;
            }
            else if (output_unit == "km")
            {
                distance = distance * 0.001;
            }
            else if (output_unit == "ft")
            {
                distance = distance * 3.2808399;
            }
            else if (output_unit == "yd")
            {
                distance = distance * 1.0936133;
            }
            else if (output_unit == "m")
            {
                distance = distance * 1;
            }

            Console.WriteLine("{0} {1}",distance,output_unit);
        }
    }
}
