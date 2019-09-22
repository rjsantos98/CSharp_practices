using System;
using System.Globalization;

namespace URI1118Varias_Notas_Com_Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, Media;
            int n3 = 1;

            while (n3 == 1)
            {
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n1 < 0.0 || n1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n2 < 0.0 || n2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                Media = (n1 + n2) / 2.0;
                Console.WriteLine("media = " + Media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                n3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n3 < 1 || n3 > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    n3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}