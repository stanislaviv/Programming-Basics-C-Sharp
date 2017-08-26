using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100days_after
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            String format = "dd-MM-yyyy";
            DateTime birhtday = DateTime.ParseExact(Console.ReadLine(), format, provider);
            DateTime newdate = birhtday.AddDays(999);
            Console.WriteLine(newdate.ToString("dd-MM-yyyy"));
        }
    }
}
