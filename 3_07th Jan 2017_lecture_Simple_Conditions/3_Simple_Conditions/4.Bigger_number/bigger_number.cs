using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Bigger_number
{
    class bigger_number
    {
        static void Main(string[] args)
        {
            var FirstNumber = int.Parse(Console.ReadLine());
            var SecondNumber = int.Parse(Console.ReadLine());

            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine(FirstNumber);
            }
            else
            {
                Console.WriteLine(SecondNumber);
            }

        }
    }
}
