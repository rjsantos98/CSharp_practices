using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1158SomaImpares3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y, c, d;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
                if (X % 2 == 0)
                {
                    X++;
                    c = 0;
                    for (int j = 1; j <= Y; j++)
                    {
                        c += X;
                        X += 2;
                    }
                    Console.WriteLine(c);
                }
                else if (X % 2 != 0)
                {
                    d = 0;
                    for (int k = 1; k <= Y; k++)
                    {
                        d += X;
                        X += 2;
                    }
                    Console.WriteLine(d);
                }
            }
            Console.ReadLine();
        }
    }
}
