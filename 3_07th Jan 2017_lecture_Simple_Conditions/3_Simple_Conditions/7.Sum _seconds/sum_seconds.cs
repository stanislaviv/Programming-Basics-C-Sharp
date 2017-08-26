using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum__seconds
{
    class sum_seconds
    {
        static void Main(string[] args)
        {
            //int sec1 = int.Parse(Console.ReadLine());
            //int sec2 = int.Parse(Console.ReadLine());
            //int sec3 = int.Parse(Console.ReadLine());
            //int sec_total = sec1 + sec2 + sec3;

            //if (sec_total <= 59)
            //{
            //    Console.WriteLine($"{"0:"}{sec_total:00}");
            //}

            //else if (sec_total <= 119)
            //{
            //    Console.WriteLine($"{"1:"}{sec_total%60:00}");
            //}

            //else if (sec_total <= 179)
            //{
            //    Console.WriteLine($"{"2:"}{sec_total % 60:00}");
            //}


            //int sec1 = int.Parse(Console.ReadLine());
            //int sec2 = int.Parse(Console.ReadLine());
            //int sec3 = int.Parse(Console.ReadLine());
            //int sec_total = sec1 + sec2 + sec3;

            //Console.WriteLine("{0}:{1:00}",(sec_total/60),(sec_total%60));




            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int sec_total = sec1 + sec2 + sec3;
            var mins = 0;

            if (sec_total<=59)
            {
                mins = 0;
                sec_total = sec_total + 0;
            }

            else if (sec_total<120)
            {
                mins++;
                sec_total = sec_total - 60;
            }
            else if (sec_total < 180)
            {
                mins=mins+2;
                sec_total = sec_total - 120;
            }

            if (sec_total < 10)
            {
                Console.WriteLine(mins + ":" + "0" + sec_total);
            }
            else
            {
                Console.WriteLine(mins+":"+sec_total);
            }







        }
    }
}
