using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 1; d2 < 10; d2++)
                {
                    for (int d3 = 1; d3 < 10; d3++)
                    {
                        for (int d4 = 1; d4 < 10; d4++)
                        {
                            if ((n % d1 == 0) && (n % d2 == 0) && (n % d3 == 0) && (n % d4 == 0))
                            {
                                Console.Write("{0}{1}{2}{3} " , d1, d2, d3, d4);
                            }
                        }
                    }
                }
            }
        }
    }
}
