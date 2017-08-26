using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());
            var biggest = int.MinValue;

            for (int i = 0; i < numberCount; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number>biggest)
                {
                    biggest = number;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
