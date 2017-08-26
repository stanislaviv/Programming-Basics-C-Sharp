using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Salaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var lectures = double.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
           

            var jelev = 0;
            var royal = 0;
            var roli = 0;
            var trofon = 0;
            var sino = 0;
            var others = 0;


            for (int i = 1; i <= lectures; i++)
            {
                string name = Console.ReadLine().ToLower();
                if (name=="jelev")
                {
                    jelev++;
                }
                else if (name=="royal")
                {
                    royal++;
                }

                else if (name == "roli")
                {
                    roli++;
                }

                else if (name=="trofon")
                {
                    trofon++;
                }
                else if (name=="sino")
                {
                    sino++;
                }
                else
                {
                    others++;
                }

                
            }
            Console.WriteLine($"Jelev salary: {(budget/lectures)*jelev:f2} lv" );
            Console.WriteLine($"RoYaL salary: {(budget / lectures) * royal:f2} lv");
            Console.WriteLine($"Roli salary: {(budget / lectures) * roli:f2} lv");
            Console.WriteLine($"Trofon salary: {(budget / lectures) * trofon:f2} lv");
            Console.WriteLine($"Sino salary: {(budget / lectures) * sino:f2} lv");
            Console.WriteLine($"Others salary: {(budget / lectures) * others:f2} lv");



        }
    }
}
