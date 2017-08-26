using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());
            var OddSum = 0.0;
            var OddMin = double.MaxValue;
            var OddMax = double.MinValue;
            var EvenSum = 0.0;
            var EvenMin = double.MaxValue;
            var EvenMax = double.MinValue;

            for (int i = 1; i <= numbersCount; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += number;
                    if (number > EvenMax)
                    {
                        EvenMax = number;
                    }
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }

                }

                else
                {
                    OddSum += number;
                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }


                }

                if (numbersCount == 1)
                {
                    OddSum = OddMin = OddMax = number;
                    EvenSum = 0;

                    Console.WriteLine($"OddSum={number}");
                    Console.WriteLine($"OddMin={number}");
                    Console.WriteLine($"OddMax={number}");
                    Console.WriteLine($"EvenSum={0}");
                    Console.WriteLine($"EvenMin={"No"}");
                    Console.WriteLine($"EvenMax={"No"}");
                }
            }

            if (numbersCount != 1 && numbersCount != 0)
            {
                Console.WriteLine($"OddSum={OddSum}");
                Console.WriteLine($"OddMin={OddMin}");
                Console.WriteLine($"OddMax={OddMax}");
                Console.WriteLine($"EvenSum={EvenSum}");
                Console.WriteLine($"EvenMin={EvenMin}");
                Console.WriteLine($"EvenMax={EvenMax}");
            }
            else if(numbersCount==0)
            {
                Console.WriteLine($"OddSum={0}");
                Console.WriteLine($"OddMin={"No"}");
                Console.WriteLine($"OddMax={"No"}");
                Console.WriteLine($"EvenSum={0}");
                Console.WriteLine($"EvenMin={"No"}");
                Console.WriteLine($"EvenMax={"No"}");
            }





        }
    }

}
