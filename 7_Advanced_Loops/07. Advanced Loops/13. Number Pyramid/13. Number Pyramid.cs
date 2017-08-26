using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var initial = 1;

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write(initial + " ");
                    initial++;

                    if (initial>n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (initial>n)
                {
                    break;
                }
            }
        }
    }
}
