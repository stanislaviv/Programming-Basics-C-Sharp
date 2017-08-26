using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //upper row
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('*',2*n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
           

            //middle part

            char special_symbol = ' ';
            for (int i = 1; i <=n-2; i++)
            {
                if (i== (n-1) /2)
                {
                special_symbol = '|';
                }
                Console.Write("*" + new string('/',2*n-2)+"*");
                Console.Write(new string(special_symbol,n));
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");
                special_symbol = ' ';
            }


            //bottom line
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine();
        }
    }
}
