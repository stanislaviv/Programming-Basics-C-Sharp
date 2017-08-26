using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var spaces_in_top = n - 1;

            //upper part

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', spaces_in_top - i));
                Console.Write("*");

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                
            }

            //second part
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', 1 + i));
                Console.Write("*");

                for (int j = 0; j <n-2-i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }




    }



}


