using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var height = 3 * 2 + 2;
            int dots_first_row = n;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 5 * n - 2 * n));

            int dots = n - 1;
            int innerdots = 3 * n;
            for (int i = 1; i <= n - 1; i++)
            {

                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', innerdots));
                dots -= 1;
                innerdots += 2;
            }
            Console.WriteLine(new string('*',5*n));



            int dots_lower = 1;
            int innerdots_lower = 5 * n - 4;
            for (int i = 1; i <= 2*n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots_lower), new string('.', innerdots_lower));
                dots_lower += 1;
                innerdots_lower -= 2;
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', dots_lower), new string('*', innerdots_lower));

        }
    }
}
