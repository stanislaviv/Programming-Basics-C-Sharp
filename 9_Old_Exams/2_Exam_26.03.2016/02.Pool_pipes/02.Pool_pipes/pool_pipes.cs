using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pool_pipes
{
    class pool_pipes
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var D1 = int.Parse(Console.ReadLine());
            var D2 = int.Parse(Console.ReadLine());
            var T = double.Parse(Console.ReadLine());
            var volume = T * D1 + T * D2;
            var fulness = (int)((volume / V)*100);
            var pipe1 = (int)((T * D1) / volume*100);
            var pipe2 = (int)((T * D2) / volume*100);
            var overflow = volume - V;

            if (V >= volume)
            {


                Console.WriteLine($"The pool is {fulness}% full. Pipe 1: {pipe1}%. Pipe 2: {pipe2}%.");
            }
            else
            {
                Console.WriteLine($"For {T} hours the pool overflows with {overflow} liters.");
            }




        }
    }
}
