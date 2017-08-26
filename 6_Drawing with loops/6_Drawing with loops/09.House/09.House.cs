using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var roof_heght = (n + 1) / 2;
            int stars_on_roof;

            if (n%2==1)
            {
                stars_on_roof = 1;
            }

            else
            {
                stars_on_roof = 2;
            }

            int dashes_per_side = (n - stars_on_roof) / 2;

            for (int i = 0; i < roof_heght; i++)
            {
                Console.Write($"{new string('-',dashes_per_side)}{new string('*',stars_on_roof)}{ new string('-', dashes_per_side) }");
                dashes_per_side--;
                stars_on_roof += 2;
                Console.WriteLine();

            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*',n-2));
                Console.WriteLine("|");
                
            }
            
        }
    }
}
