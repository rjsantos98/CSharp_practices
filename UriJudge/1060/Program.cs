using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1060Positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f; 
            int contador;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contador = 0;

            if (a >= 0)
            {
                contador = contador + 1;
            }
            if (b >= 0)
            {
                contador = contador + 1;
            }
            if (c >= 0)
            {
                contador = contador + 1;
            }
            if (d >= 0)
            {
                contador = contador + 1;
            }
            if (e >= 0)
            {
                contador = contador + 1;
            }
            if (f >= 0)
            {
                contador = contador + 1;
            }
            Console.WriteLine(contador +" valores positivos");
            Console.ReadLine();
        }
    }
}
