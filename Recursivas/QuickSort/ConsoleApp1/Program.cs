using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] vetor = { 10, 20, 13, 16, 1, 5, 3, 2 , 12, 17 };
        //                   { 1, 2, 3, 5, 10, 12, 13, 16, 17, 20 }
        static void Main(string[] args)
        {
            Console.WriteLine("Método recursivo QuickSort");

            foreach (var numero in vetor) Console.Write(numero + " ");

            QuickSort( 0, vetor.Length-1);

            Console.WriteLine();
            foreach (var numero in vetor) Console.Write(numero+" ");
            Console.Read();
        }

        static public void QuickSort(int primeiro, int ultimo)
        {

            int baixo, alto, meio, pivo, repositorio;
            baixo = primeiro;
            alto = ultimo;
            meio = (int)((baixo + alto) / 2);

            pivo = vetor[meio];

            while (baixo <= alto)
            {
                while (vetor[baixo] < pivo)
                    baixo++;
                while (vetor[alto] > pivo)
                    alto--;
                if (baixo < alto)
                {
                    repositorio = vetor[baixo];
                    vetor[baixo++] = vetor[alto];
                    vetor[alto--] = repositorio;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }
            }

            if (alto > primeiro)
                QuickSort(primeiro, alto);
            if (baixo < ultimo)
                QuickSort(baixo, ultimo);
        }
    }
}
