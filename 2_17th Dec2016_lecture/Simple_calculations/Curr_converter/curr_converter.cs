using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curr_converter
{
    class curr_converter
    {
        static void Main(string[] args)

        {
            var curency_amount = double.Parse(Console.ReadLine());
            string input_cur = Console.ReadLine().ToUpper();
            string output_cur = Console.ReadLine().ToUpper();
            double BGNinUSD = curency_amount * 1.79549;
            double BGNinEUR = curency_amount * 1.95583;
            double BGNinGBP = curency_amount * 2.53405;


            if (input_cur=="USD")
            {
                curency_amount = BGNinUSD;
            }
            else if (input_cur=="EUR")
            {
                curency_amount = BGNinEUR;
            }

            else if (input_cur=="GBP")
            {
                curency_amount = BGNinGBP;
            }

            else if(input_cur=="BGN")
            {
                curency_amount = curency_amount * 1;
            }


            if (output_cur=="USD")
            {
                curency_amount = curency_amount / 1.79549;
            }

            else if (output_cur =="EUR")
            {
                curency_amount = curency_amount / 1.95583;
            }

            else if (output_cur =="GBP")
            {
                curency_amount = curency_amount / 2.53405;
            }

            else if (output_cur =="BGN")
            {
                curency_amount = curency_amount / 1;
            }

            Console.WriteLine("{0} {1}", Math.Round(curency_amount, 2), output_cur.ToUpper());




        }
    }
}
