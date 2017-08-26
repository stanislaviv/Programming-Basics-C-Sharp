using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Num_from_100_to_200
{
    class num100_200
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number <= 200)
                Console.WriteLine("Between 100 and 200");

            else
            {
                Console.WriteLine("Greater than 200");
            }

        }
    }
}
