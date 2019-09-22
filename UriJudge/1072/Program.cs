using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1072Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, dentro, fora;

            N = int.Parse(Console.ReadLine());
            X = 0;
            dentro = 0;
            fora = 0;


            for (int i = 0; i < N; i++)
            { 
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                dentro++;

                }
                else
                {
                fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
            Console.ReadKey();
        }
    }
}
