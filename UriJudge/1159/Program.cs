using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1159SomaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, n1, n2, n3, n4, n5, soma;

            X = int.Parse(Console.ReadLine());
            n1 = X;
            n2 = n1;
            n3 = n2;
            n4 = n3;
            soma = 0;

            while (X != 0)
            {
                if (X % 2 != 0)
                {
                    X = X + 1;
                    n1 = X + 2;
                    n2 = n1 + 2;
                    n3 = n2 + 2;
                    n4 = n3 + 2;
                    soma = X + n1 + n2 + n3 + n4;
                    Console.WriteLine(soma);
                }
                else
                {
                    n1 = X + 2;
                    n2 = n1 + 2;
                    n3 = n2 + 2;
                    n4 = n3 + 2;
                    soma = X + n1 + n2 + n3 + n4;
                    Console.WriteLine(soma);
                }
                X = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
