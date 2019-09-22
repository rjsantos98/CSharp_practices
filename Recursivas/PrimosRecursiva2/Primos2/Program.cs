using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimoOuNao(0, 2);
            void PrimoOuNao(int numero, int contador)
            {
                if (numero == 0)
                {
                    Console.Write("Digite um número: ");
                    numero = int.Parse(Console.ReadLine());
                }
                if (numero < 2 || numero == 1 && contador == numero)
                {
                    Console.WriteLine(numero + " não é primo");
                }
                else if (contador == numero)
                {
                    Console.WriteLine(numero + " é primo");
                    numero = 0;
                    PrimoOuNao(numero, contador = 2);
                }
                else
                {
                    if ((numero % contador) == 0)
                    {
                        Console.WriteLine(numero + " não é primo");
                    }
                    else
                    {
                        PrimoOuNao(numero, contador + 1);
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
