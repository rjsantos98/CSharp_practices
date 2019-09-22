using System;
using System.Globalization;

namespace URI1046Tempo
{
    class Program
    {
        static void Main(string[] args)
        {

            int hInicio, hFinal, tempo;
            string[] vet = Console.ReadLine().Split(' ');

            hInicio = int.Parse(vet[0]);
            hFinal = int.Parse(vet[1]);


            if (hInicio < hFinal)
            {
                tempo = hFinal - hInicio;

            }
            else
            {
                tempo = (24 - hInicio) + hFinal;

            }

            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");


        }
    }
}