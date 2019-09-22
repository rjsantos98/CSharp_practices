using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número positivo: ");
            int numero = int.Parse(Console.ReadLine());

            SequenciaDePrimos(1,numero);

            Console.ReadKey();
        }

        static bool NumeroPrimo(int numero, int contagem)
        {
            if(numero< 2)
            {
                return false;
            }
            if (contagem == numero)
            {
                return true;
            }
            else
            {
                if ((numero % contagem) == 0)
                {
                    return false;
                }
                else
                {
                    return NumeroPrimo(numero,contagem+1);
                }
            }
        }

        static void SequenciaDePrimos(int contagem, int numero)
        {
            if(NumeroPrimo(contagem, 2))
            {
                Console.WriteLine("Ó número '"+contagem+"' é Primo");
            }
            if (contagem < numero)
            {
                SequenciaDePrimos(contagem + 1, numero);
            }
        }
    }
}
