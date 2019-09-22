using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1157Divisores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, div = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                div = N / i;
                if (N%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
