using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string specialsymbol = "|";


            for (int j = 0; j < n; j++)
            {

                if (j==0 || j==n-1)
                {
                    specialsymbol = "+";
                }
                Console.Write(specialsymbol);
                for (int c = 1; c <= n - 2; c++)
                {
                    Console.Write(" -");
                }
                Console.Write(' '+specialsymbol);
                Console.WriteLine();
                specialsymbol = "|";
            }

        }
    }
}
