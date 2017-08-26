using System;

class Histogram
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var p1 = 0;
        var p2 = 0;
        var p3 = 0;
        var p4 = 0;
        var p5 = 0;
        for (int i = 0; i < n; i++)
        {
            var num = int.Parse(Console.ReadLine());
            if (num < 200) p1++;
            else if (num < 400) p2++;
            else if (num < 600) p3++;
            else if (num < 800) p4++;
            else p5++;
        }

        var p1Percentage = p1 * 100.0 / n;
        var p2Percentage = p2 * 100.0 / n;
        var p3Percentage = p3 * 100.0 / n;
        var p4Percentage = p4 * 100.0 / n;
        var p5Percentage = p5 * 100.0 / n;

        Console.WriteLine("{0:f2}%", p1Percentage);
        Console.WriteLine("{0:f2}%", p2Percentage);
        Console.WriteLine("{0:f2}%", p3Percentage);
        Console.WriteLine("{0:f2}%", p4Percentage);
        Console.WriteLine("{0:f2}%", p5Percentage);
    }
}

