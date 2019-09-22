using System;
using System.Globalization;

namespace URI1017Gasto
{
    class Program
    {
        static void Main(string[] args)
        {
            double gasto, horas, velocidade;

            horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            velocidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 
            gasto = (horas * velocidade) / 12;

            Console.WriteLine(""+ gasto.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
