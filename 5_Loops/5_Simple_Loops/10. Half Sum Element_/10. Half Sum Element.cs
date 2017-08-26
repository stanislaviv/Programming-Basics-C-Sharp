using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element_
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());
            var biggest = int.MinValue;
            var sum_all = 0;

            for (int i = 0; i < numberCount; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > biggest)
                {
                    biggest = number;
                }
                sum_all += number;
            }

            if (sum_all - biggest == biggest)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggest}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(biggest - Math.Abs(sum_all - biggest))}");
                Console.WriteLine(sum_all);
                Console.WriteLine(biggest);
            }
        }
    }
}
