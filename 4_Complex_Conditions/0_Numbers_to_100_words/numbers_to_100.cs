using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Numbers_to_100_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var output = "";

            if (number > 100 || number < 0)
            {
                Console.WriteLine("Invalid Number");
            }

            else
            {

                if (number > 19 && number < 100)
                {
                    int tens = number / 10;
                    int units = number % 10;

                    switch (tens)
                    {
                        case 2:
                            output += "twenty";
                            break;
                        case 3:
                            output += "thirty";
                            break;
                        case 4:
                            output += "fourty";
                            break;
                        case 5:
                            output += "fifty";
                            break;
                        case 6:
                            output += "sixty";
                            break;
                        case 7:
                            output += "seventy";
                            break;
                        case 8:
                            output += "eighty";
                            break;
                        case 9:
                            output += "ninety";
                            break;
                    }

                    switch (units)
                    {
                        case 1:
                            output += " one";
                            break;
                        case 2:
                            output += " two";
                            break;
                        case 3:
                            output += " three";
                            break;
                        case 4:
                            output += " four";
                            break;
                        case 5:
                            output += " five";
                            break;
                        case 6:
                            output += " six";
                            break;
                        case 7:
                            output += " seven";
                            break;
                        case 8:
                            output += " eight";
                            break;
                        case 9:
                            output += " nine";
                            break;
                    }
                }
                else if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else if (number == 0)
                {
                    Console.WriteLine("zero");
                }



                else
                    switch (number)
                    {
                        case 1:
                            output += "one";
                            break;
                        case 2:
                            output += "two";
                            break;
                        case 3:
                            output += "three";
                            break;
                        case 4:
                            output += "four";
                            break;
                        case 5:
                            output += "five";
                            break;
                        case 6:
                            output += "six";
                            break;
                        case 7:
                            output += "seven";
                            break;
                        case 8:
                            output += "eight";
                            break;
                        case 9:
                            output += "nine";
                            break;
                        case 10:
                            output += "ten";
                            break;
                        case 11:
                            output += "eleven";
                            break;
                        case 12:
                            output += "twelve";
                            break;
                        case 13:
                            output += "thirteen";
                            break;
                        case 14:
                            output += "fourteen";
                            break;
                        case 15:
                            output += "fifteen";
                            break;
                        case 16:
                            output += "sixteen";
                            break;
                        case 17:
                            output += "seventeen";
                            break;
                        case 18:
                            output += "eighteen";
                            break;
                        case 19:
                            output += "nineteen";
                            break;
                    }
                Console.WriteLine(output);
            }
          


        }
    }


}









