using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.
namespace URI1080MaiorePosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, maior, posicao;

            maior = 0;
            posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                N = int.Parse(Console.ReadLine());
                if (N > maior)
                {
                    maior = N;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            Console.ReadLine();
        }
    }
}
