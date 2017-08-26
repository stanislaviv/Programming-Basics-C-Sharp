using System;

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int halfRowSize = n - 2;

        for (int i = 1; i <= halfRowSize; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("{0}\\ /{0}", new string('*', halfRowSize));
            }
            else
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', halfRowSize));
            }
        }

        Console.WriteLine("{0} @ {0}", new string(' ', halfRowSize));

        for (int i = 1; i <= halfRowSize; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("{0}/ \\{0}", new string('*', halfRowSize));
            }
            else
            {
                Console.WriteLine("{0}/ \\{0}", new string('-', halfRowSize));
            }
        }
    }
}

