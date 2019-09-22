using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1065pARES
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, Par, impar, neg, pos;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            Par = 0;
            impar = 0;
            neg = 0;
            pos = 0;

            if (n1 % 2 == 0)
            {
                Par += 1;
            }
            else if (n1 % 2 != 0)
            {
                impar += 1;
            }
            if (n1 < 0)
            {
                neg += 1;
            }
            else if (n1 > 0)
            {
                pos += 1;
            }

            if (n2 % 2 == 0)
            {
                Par += 1;
            }
            else if (n2 % 2 != 0)
            {
                impar += 1;
            }
            if (n2 < 0)
            {
                neg += 1;
            }
            else if (n2 > 0)
            {
                pos += 1;
            }

            if (n3 % 2 == 0)
            {
                Par += 1;
            }
            else if (n3 % 2 != 0)
            {
                impar += 1;
            }
            if (n3 < 0)
            {
                neg += 1;
            }
            else if (n3 > 0)
            {
                pos += 1;
            }

            if (n4 % 2 == 0)
            {
                Par += 1;
            }
            else if (n4 % 2 != 0)
            {
                impar += 1;
            }
            if (n4 < 0)
            {
                neg += 1;
            }
            else if (n4 > 0)
            {
                pos += 1;
            }

            if (n5 % 2 == 0)
            {
                Par += 1;
            }
            else if (n5 % 2 != 0)
            {
                impar += 1;
            }
            if (n5 < 0)
            {
                neg += 1;
            }
            else if (n5 > 0)
            {
                pos += 1;
            }

            Console.WriteLine(Par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");
            Console.ReadLine();

        }
    }
}