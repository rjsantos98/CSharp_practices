using System;
using System.Globalization;

namespace URI1050DDD
{
    class Program
    {
        static void Main(string[] args)
        {

            int ddd;
            string destino;

            ddd = int.Parse(Console.ReadLine());

            if (ddd == 11)
            {
                destino = "Sao Paulo";
                Console.WriteLine(destino);
            }
            else if (ddd == 61)
            {
                destino = "Brasilia";
                Console.WriteLine(destino);
            }
            else if (ddd == 71)
            {
                destino = "Salvador";
                Console.WriteLine(destino);
            }
            else if (ddd == 21)
            {
                destino = "Rio de Janeiro";
                Console.WriteLine(destino);
            }
            else if (ddd == 32)
            {
                destino = "Juiz de Fora";
                Console.WriteLine(destino);
            }
            else if (ddd == 19)
            {
                destino = "Campinas";
                Console.WriteLine(destino);
            }
            else if (ddd == 27)
            {
                destino = "Vitoria";
                Console.WriteLine(destino);
            }
            else if (ddd == 31)
            {
                destino = "Belo Horizonte";
                Console.WriteLine(destino);
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }

            Console.ReadLine();
        }
    }
}

