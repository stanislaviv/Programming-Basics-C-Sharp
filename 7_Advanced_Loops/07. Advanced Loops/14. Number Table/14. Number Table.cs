using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= n; col++)
                {
                    Console.Write(col + " ");
                }


                for (int i = n; i >n-row+1; i--)
                {
                    Console.Write((i-1)+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
