﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");

                for (int j = 1; j < i; j++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }

        }
    }
}
