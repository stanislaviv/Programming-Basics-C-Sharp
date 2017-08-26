using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Plochki_remont
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());

            var area = N * N;
            var peika = M * O;
            var plochka = W * L;
            var broi_plochki = (area - peika) / plochka;
            var vreme = broi_plochki * 0.2;

            Console.WriteLine(broi_plochki);
            Console.WriteLine(vreme);


        }
    }
}
