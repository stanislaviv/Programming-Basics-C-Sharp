using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var last = int.Parse(Console.ReadLine());
            var first = int.Parse(Console.ReadLine());
            var magic_number = int.Parse(Console.ReadLine());

            var combinations = 0;
            var magic_number_count = 0;

        

            for (int i = last; i >= first; i--)
            {
                for (int j = last; j >= first; j--)
                {
                    combinations++;


                    if (i + j == magic_number)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magic_number})");
                        magic_number_count++;
                        return;
                        
                    }


                }
                
            }

            if (magic_number_count==0)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magic_number}");
            }
            
            


        }
    }
}
