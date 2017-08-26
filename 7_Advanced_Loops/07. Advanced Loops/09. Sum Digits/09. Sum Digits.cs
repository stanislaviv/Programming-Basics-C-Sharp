using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var tempSum = 0;

            do
            {
                tempSum += num % 10;
                num = num / 10;
            } while (num > 0);
            Console.WriteLine(tempSum);

            
        }
    }
}
