using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int untreated = 0;

            for (int i = 1; i <= days; i++)
            {
                var patients = int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (untreated > treated))
                {
                    doctors += 1;
                }

                if (patients > doctors)
                {
                    untreated += patients - doctors;
                    treated += doctors;
                }
                else
                {
                    treated += patients;
                }
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");


        }
    }
}
