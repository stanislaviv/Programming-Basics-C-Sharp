using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        private static int sum_even;
        private static int sum_odd;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            sum_even = 0;
            sum_odd = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sum_even += number;
                }
                else
                {
                    sum_odd += number;
                }
            }

            if (sum_even==sum_odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum_odd}");
            }
            else
            {

                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum_odd-sum_even)}");
            }
        }
    }
}
