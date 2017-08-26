using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var last = int.Parse(Console.ReadLine());

            var max = int.Parse(Console.ReadLine());
            var combinations_count = 0;

            for (int i = first; i <= last; i++)
            {
                for (int j = first; j <= last; j++)
                {
                    combinations_count++;
                    Console.Write("<{0}-{1}>",i,j);
                    
                
                    if (combinations_count>=max)
                    {
                        return;
                    }
                   
                }
            }
        }
    }
}
