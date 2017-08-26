using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());

            var max = int.Parse(Console.ReadLine());
            var current_battles = 0;

            for (int i = 1; i <= P1; i++)
            {
                for (int j = 1; j <= P2; j++)
                {
                    current_battles++;
                    Console.Write("({0} <-> {1}) ", i, j);
                    if (current_battles >= max)
                    {
                        return;
                    }
                    
                        
                }

            }
        

        }
    }
}
