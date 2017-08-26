using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var leftdashes = 3 * n;
            var middledashes = 0;
            var rightdashes = 2 * n - 2;

            //upper part

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftdashes), new string('-', middledashes), new string('-', rightdashes));
                middledashes++;
                rightdashes--;
            }

            //axe handle

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftdashes), new string('-', middledashes-1), new string('-', rightdashes+1));
            }

            //axe blade

            for (int i = 1; i <= n / 2; i++)

            {
                if (!(i==n/2))
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftdashes), new string('-', middledashes-1), new string('-', rightdashes+1));
                    leftdashes--;
                    middledashes += 2;
                    rightdashes--;
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftdashes), new string('*', middledashes-1), new string('-', rightdashes+1));
                    leftdashes--;
                    middledashes += 2;
                    rightdashes--;
                }
            
            }
        }
    }
}
