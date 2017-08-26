using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (age > 16)
            {
                switch (gender)
                {
                    case "m":
                        Console.WriteLine("Mr.");
                        break;
                    case "f":
                        Console.WriteLine("Ms.");
                        break;
                }
            }
            else
            {
                if (gender=="m")
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss.");
                }
            }
            }
        }
    }
