using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var exam_hour = int.Parse(Console.ReadLine());
            var exam_minute = int.Parse(Console.ReadLine());
            var arrival_hour = int.Parse(Console.ReadLine());
            var arrival_minute = int.Parse(Console.ReadLine());

            var exam_total_minutes = exam_hour * 60 + exam_minute;
            var arrival_total_minutes = arrival_hour * 60 + arrival_minute;
            var difference_late = arrival_total_minutes - exam_total_minutes;
            var difference_early = exam_total_minutes - arrival_total_minutes;


            if (arrival_total_minutes > exam_total_minutes)
            {
                if (difference_late < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{arrival_total_minutes - exam_total_minutes} minutes after the start");
                }
                else if (difference_late >= 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difference_late/ 60}{":"}{difference_late % 60:00} hours after the start");
                    Console.WriteLine(difference_late % 60);
                }
            }
            else if (arrival_total_minutes < exam_total_minutes)
            {
                if (difference_early <=30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference_early} minutes before the start");
                }
                else if (difference_early > 30 && difference_early <60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference_early} minutes before the start");
                }
                else if ((difference_early >= 60))
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference_early /60}{":"}{difference_early% 60:00} hours before the start");
                }                         
            }
            else
            {
                Console.WriteLine("On time");
            }

        }
    }
}
