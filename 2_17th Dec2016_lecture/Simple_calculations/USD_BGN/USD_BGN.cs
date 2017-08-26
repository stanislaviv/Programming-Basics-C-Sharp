using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_BGN
{
    class USD_BGN
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            var BGN = Math.Round(USD * 1.79549, 2);
            Console.WriteLine(BGN);
        }
    }
}
