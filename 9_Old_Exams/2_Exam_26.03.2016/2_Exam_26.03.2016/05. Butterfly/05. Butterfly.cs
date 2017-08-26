using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n - 1;
            var height = 2 * (n - 2) + 1;
            char special_symbol = '*';

            for (int i = 1; i <= n - 2; i++)
            {
                
                if (i % 2 == 0)
                {
                    special_symbol = '-';
                }
                Console.WriteLine("{0}\\ /{0}", new string(special_symbol, (width - 3) / 2));
                special_symbol = '*';
                
            }

            Console.WriteLine("{0}@",new string(' ',(width-1)/2));

            for (int i = 1; i <= n - 2; i++)
            {

                if (i % 2 == 0)
                {
                    special_symbol = '-';
                }
                Console.WriteLine("{0}/ \\{0}", new string(special_symbol, (width - 3) / 2));
                special_symbol = '*';

            }

        }
    }
}
