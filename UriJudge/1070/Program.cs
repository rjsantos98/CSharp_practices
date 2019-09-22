using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1070NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, n1, n2, n3, n4, n5, n6;

            X = int.Parse(Console.ReadLine());

            n1 = X;
            n2 = n1;
            n3 = n2;
            n4 = n3;
            n5 = n4;

            if (X % 2 == 0)
            {
                X = X + 1;
                n1 = X + 2;
                n2 = n1 + 2;
                n3 = n2 + 2;
                n4 = n3 + 2;
                n5 = n4 + 2;
            }
            else
            {
                n1 = X + 2;
                n2 = n1 + 2;
                n3 = n2 + 2;
                n4 = n3 + 2;
                n5 = n4 + 2;
            }
            Console.WriteLine(X);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.ReadLine();
        }
    }
}