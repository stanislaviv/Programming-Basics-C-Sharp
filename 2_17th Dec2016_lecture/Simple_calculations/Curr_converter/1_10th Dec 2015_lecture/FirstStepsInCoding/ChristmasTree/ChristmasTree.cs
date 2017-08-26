using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        public static int i { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("Enter Christmas Tree Size ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)

            {
                Console.WriteLine(new string(' ', n - i) + new string('*', i) + " | " + new string('*', i));
            }
       
     
        }
    }
}
