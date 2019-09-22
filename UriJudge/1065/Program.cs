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
            int n1, n2, n3, n4, n5, Par;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            Par = 0;


            if (n1 % 2 == 0)
            {
                Par += 1;
            }
            if (n2 % 2 == 0)
            {
                Par += 1;
            }
            if (n3 % 2 == 0)
            {
                Par += 1;
            }
            if (n4 % 2 == 0)
            {
                Par += 1;
            }
            if (n5 % 2 == 0)
            {
                Par += 1;
            }
            Console.WriteLine(Par + " valores pares");
            Console.ReadLine();

        }
    }
}