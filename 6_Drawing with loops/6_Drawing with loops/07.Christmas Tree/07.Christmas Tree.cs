using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n+1; i++)
            {
                Console.Write(new string(' ',n-i));
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.Write(new string('*', i));

                Console.WriteLine();


            }
        }
    }
}
