using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1149somainteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, N, i, soma, total;
            string[] vet;
            soma = 0;
            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            i = 1;

            while (int.Parse(vet[i]) <= 0)
            {
                i++;
            }

            N = int.Parse(vet[i]);

            for (i = 0; i < N; i++)
            {
                soma = soma + i;
            }
            total = (A * N) + soma;
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}