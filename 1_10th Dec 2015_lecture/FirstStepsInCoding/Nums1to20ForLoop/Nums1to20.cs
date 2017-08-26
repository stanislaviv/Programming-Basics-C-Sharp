using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums1to20_Loop_For
{
    class Program
    {
        public static bool i { get; private set; }

        static void Main(string[] args)

        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
