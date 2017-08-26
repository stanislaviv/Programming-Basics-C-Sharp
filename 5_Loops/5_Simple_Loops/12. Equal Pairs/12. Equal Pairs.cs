using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());

            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var Sum = firstNum + secondNum;
            var max_difference = 0.0;

            for (int i = 1; i < numbersCount; i++)
            {
                var num3 = int.Parse(Console.ReadLine());
                var num4 = int.Parse(Console.ReadLine());
                var TempSum = num3 + num4;
                

                if (!(Sum == TempSum))
                {
                    var diff = Math.Abs(Sum-TempSum);
                    if (diff > max_difference)
                    {
                        max_difference = diff;
                    }
                }
                Sum = TempSum;
            }

            if (max_difference == 0)
            {
                Console.WriteLine($"Yes, value={Sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={max_difference}");
            }


        }
    }
}
