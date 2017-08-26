using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = int.Parse(Console.ReadLine());

            for (int i = 1; i <= side; i++)
            {
                Console.Write("*");

                for (int j = 1; j < side; j++)
                {
                    Console.Write(" *");
                    
                }

                Console.WriteLine();
            }
        }
    }
}
