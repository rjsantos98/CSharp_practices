using System;
using System.Globalization;

namespace URI1043Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, perimetro, area;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (Math.Abs(b - c) < a && a < (b + c) || Math.Abs(a - c) < b && b < (a + c) || Math.Abs(a - b) < c && c < (a + b))
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("f1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("f1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}