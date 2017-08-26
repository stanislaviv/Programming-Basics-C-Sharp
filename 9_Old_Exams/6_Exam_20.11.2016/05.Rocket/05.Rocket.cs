using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n;

            //upper part
            var dots_on_top = (3 * n - 2) / 2;
            var spaces_on_top = 0;

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dots_on_top), new string(' ',spaces_on_top));
                dots_on_top--;
                spaces_on_top += 2;        
            }

            //middle row
            Console.WriteLine("{0}{1}{0}",new string('.',dots_on_top+1),new string('*',2*n));

            //bottom part

            var height = 2 * n;
            var inner_slashes = 2 * n - 2;
            var outer_dots = n/2;

            for (int i = 1; i <= 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', outer_dots), new string('\\',inner_slashes));
            }

            //rocket base
            var base_height = n / 2;

            for (int i = 1; i <=base_height; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',outer_dots),new string('*',inner_slashes));
                outer_dots--;
                inner_slashes += 2;

            }

            
        }
    }
}
