using System;
using System.Globalization;

namespace URI1117ValidacaoNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (n1 < 0 || n1 > 10)
            {
                Console.WriteLine("nota invalida");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (n2 < 0 || n2 > 10)
            {
                Console.WriteLine("nota invalida");
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (n1 + n2) / 2.0;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}