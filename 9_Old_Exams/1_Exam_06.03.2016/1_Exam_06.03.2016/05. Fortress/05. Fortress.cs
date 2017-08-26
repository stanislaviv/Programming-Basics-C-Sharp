using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var triangles = n / 2;
            var middle = 2 * n - 2 * triangles - 4;

            //first row

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', triangles), new string('_', middle));

            //middle part

            for (int i = 1; i <= n-3; i++)
            {
                Console.WriteLine("|{0}|",new string(' ',2*n-2));
                        
            }

            //row before last

            Console.WriteLine("|{0}{1}{0}|",new string(' ',triangles+1),new string('_',middle));

            //last row
            Console.WriteLine("\\{0}/{1}\\{0}/",new string('_',triangles),new string(' ',middle));



        }
    }
}
