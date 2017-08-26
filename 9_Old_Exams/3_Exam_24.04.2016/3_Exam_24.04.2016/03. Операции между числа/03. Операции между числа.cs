using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var N1 = int.Parse(Console.ReadLine());
            string operator_ = Console.ReadLine();

            if (operator_ == "+" || operator_ == "-" || operator_ == "*")
            {
                if (operator_ == "+")
                {
                    if ((N + N1) % 2 == 0)
                    {
                        Console.WriteLine($"{N} {operator_} {N1} = {N + N1} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N} {operator_} {N1} = {N + N1} - odd");
                    }
                }
                else if (operator_ == "-")
                {
                    if ((N - N1) % 2 == 0)
                    {
                        Console.WriteLine($"{N} {operator_} {N1} = {N - N1} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N} {operator_} {N1} = {N - N1} - odd");
                    }
                }
                else
                {
                    if ((N * N1) % 2 == 0)
                    {
                        Console.WriteLine($"{N} {operator_} {N1} = {N * N1} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N} {operator_} {N1} = {N * N1} - odd");
                    }
                }
            }
            else if (operator_=="/")
            {
                if (N1==0)
                {
                    Console.WriteLine($"Cannot divide {N} by zero");
                }
                else
                {

                    Console.WriteLine($"{N} {operator_} {N1} = {(double)N/N1:f2}");
                }
            }
            else
            {
                if (N1 == 0)
                {
                    Console.WriteLine($"Cannot divide {N} by zero");
                }
                else
                {
                    Console.WriteLine($"{N} {operator_} {N1} = {N%N1}");
                }
            }


        }
    }
}
