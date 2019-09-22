using System;
using System.Globalization;

namespace URI1044Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            string mult;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            
            if (a < b)
            {
                x = b;
                y = a;
            }
            else
            {
                x = a;
                y = b;
            }

            if ((x % y) == 0)
            {
                mult = "Sao Multiplos";
            }
            else
            {
                mult = "Nao sao Multiplos";
            }
            Console.WriteLine(mult);
            Console.ReadLine();
        }
    }
}