using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var widht = 2 * n + 3;

            var dashes_on_top = 2 * n - 1;
            var stars_on_top = 1;

            //upper part

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",new string('*',stars_on_top),new string('-',dashes_on_top));
                dashes_on_top -= 2;
                stars_on_top++;
            }

            var middle_height = n / 3;
            var middle_dashesinside = n;
            var middle_dashes_outside = n / 2;

            for (int i =1; i <=middle_height; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",new string('*',middle_dashes_outside),new string('*',middle_dashesinside));
                middle_dashesinside -= 2;
                middle_dashes_outside++;
            }

            //bottom part

            var bottom_stars = 2 * n - 1;
            var bottom_dashes = 1;

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', bottom_dashes), new string('*', bottom_stars));
                bottom_stars -= 2;
                bottom_dashes++;
            }

        }
    }
}
