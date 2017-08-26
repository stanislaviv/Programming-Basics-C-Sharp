using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Min_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());
            var smallest = int.MaxValue;

            for (int i = 0; i < numbersCount; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number<smallest)
                {
                    smallest = number;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
