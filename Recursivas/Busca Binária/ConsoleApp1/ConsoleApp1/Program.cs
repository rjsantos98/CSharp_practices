using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] vet = new int[10];
        static void Main(string[] args)
        {
            Random random = new Random(); // criando uma variavel de números aleatórios
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(20);
                foreach (var num in vet)
                {
                    if (num != numero)
                    {
                        vet[i] = numero;
                        break;
                    }
                }
            }
            Array.Sort(vet); // Colocando a lista em ordem decresente 
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Vet[{i}] = {vet[i]}");
            }
            Console.Write("Digite um número para verificar no vetor: ");
            int valordigitado = int.Parse(Console.ReadLine());

            int pos = BuscaBinaria(valordigitado, 0, vet.Length - 1);
            if (pos == -1)
            {
                Console.WriteLine("Número digitado não encontrado");
            }
            else
            {
                Console.WriteLine("Posição: " + pos);
                Console.WriteLine("Número: " + vet[pos]);
            }
            Console.ReadLine();
        }
        static int BuscaBinaria(int n, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            int meio = (min + max) / 2;
            if (n == vet[meio])
            {
                return meio;
            }
            else
            {
                if (n > vet[meio])
                {
                    return BuscaBinaria(n, meio + 1, max);
                }
                else
                {
                    return BuscaBinaria(n, min, meio - 1);
                }
            }
        }
    }
}
