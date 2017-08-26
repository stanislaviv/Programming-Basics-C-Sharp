using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var repeatCount = n * 2;
            var leftSum = 0;
            var rightSum = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    var number = int.Parse(Console.ReadLine());
            //    leftSum += number;
            //}


            //for (int i = 0; i < n; i++)
            //{
            //    var number = int.Parse(Console.ReadLine());
            //    rightSum += number;
            //}

           

            for (int i = 0; i < n*2; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (i<n)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }


        }


    }

}
