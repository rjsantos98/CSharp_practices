using System;
using System.Globalization;


namespace URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("f5"), CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}