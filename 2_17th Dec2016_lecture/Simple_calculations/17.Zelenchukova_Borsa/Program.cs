using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Zelenchukova_Borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena_zelenchuci = double.Parse(Console.ReadLine());
            double cena_plodove = double.Parse(Console.ReadLine());
            int zelenchuci_kg = int.Parse(Console.ReadLine());
            int plodove_kg = int.Parse(Console.ReadLine());

            var prihodi = (cena_zelenchuci * zelenchuci_kg + cena_plodove * plodove_kg) / 1.94;
            Console.WriteLine(prihodi);



        }
    }
}
