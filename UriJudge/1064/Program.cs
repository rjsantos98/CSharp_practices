using System;

using System.Globalization;

class URI1064PositivoseMedia
{

    static void Main(string[] args)
    {

        double a, b, c, d, e, f, sum;

        int x;

        a = double.Parse(Console.ReadLine());

        b = double.Parse(Console.ReadLine());

        c = double.Parse(Console.ReadLine());

        d = double.Parse(Console.ReadLine());

        e = double.Parse(Console.ReadLine());

        f = double.Parse(Console.ReadLine());

        x = 0;

        sum = 0.0;

        if (a > 0.0)
        {

            ++x;

            sum += a;

        }

        if (b > 0.0)
        {

            ++x;

            sum += b;

        }

        if (c > 0.0)
        {

            ++x;

            sum += c;

        }

        if (d > 0.0)
        {

            ++x;

            sum += d;

        }

        if (e > 0.0)
        {

            ++x;

            sum += e;

        }

        if (f > 0.0)
        {

            ++x;

            sum += f;

        }

        Console.WriteLine(x + " valores positivos");
        double media = sum / x;
        Console.WriteLine(media.ToString("F1"));
        Console.ReadLine();

    }

}