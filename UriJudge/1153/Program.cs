using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1153FatoresSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, fatorial, i;
            N = int.Parse(Console.ReadLine());
            fatorial = 1;

                for (i = N; i >= 1; i--)
                {
                    fatorial *=  i;
                }

            Console.WriteLine(fatorial);
            Console.ReadKey();
        }
    }
}
