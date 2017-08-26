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

            //upper part
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            //middle part

            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("|");
                for (int c = 1; c <= n-2; c++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }

            //upper part
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
