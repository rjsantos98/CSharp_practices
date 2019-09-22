using System;
using System.Globalization;

namespace uri1045Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, a, b, c;

            String[] vet = Console.ReadLine().Split(' ');

            valor1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            valor2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            valor3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (valor1 >= valor2 && valor1 >= valor3 && valor2 >= valor3)
            {
                a = valor1;
                b = valor2;
                c = valor3;
            }
            else if (valor1 <= valor2 && valor1 >= valor3 && valor2 >= valor3)
            {
                a = valor2;
                b = valor1;
                c = valor3;
            }
            else if (valor1 <= valor2 && valor1 <= valor3 && valor2 >= valor3)
            {
                a = valor2;
                b = valor3;
                c = valor1;
            }
            else if (valor1 >= valor2 && valor1 >= valor3 && valor2 <= valor3)
            {
                a = valor1;
                b = valor3;
                c = valor2;
            }
            else if (valor1 >= valor2 && valor1 <= valor3 && valor2 <= valor3)
            {
                a = valor3;
                b = valor1;
                c = valor2;
            }
            else
            {
                a = valor3;
                b = valor2;
                c = valor1;
            }

            if (a >= (b + c))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }

                if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && a == c && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            Console.ReadLine();
        }
    }
}