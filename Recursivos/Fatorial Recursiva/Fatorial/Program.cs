using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fatorial de {numero} = " + Fatorial(numero));

            Console.Read();
        }

        static int Fatorial(int numero)
        {
            if (numero == 1)
            {
                return 1;
            }
            else
            {
                return numero = numero * Fatorial(numero - 1);
            }

        }
    }
}
