using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1042SortSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int x, y, z;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            x = a;
            y = b;
            z = c;


            if (a < b && a < c && b < c) { x = a; y = b; z = c; }
            else if (a < b && a < c && b > c) { x = a; y = c; z = b; }
            else if (b < a && b < c && a < c) { x = b; y = a; z = c; }
            else if (b < a && b < c && a > c) { x = b; y = c; z = a; }
            else if (c < a && c < b && a < b) { x = c; y = a; z = b; }
            else if (c < a && c < b && a > b) { x = c; y = b; z = a; }

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}