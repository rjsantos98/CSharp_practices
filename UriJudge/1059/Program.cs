using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1059NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            for (int i = 1; i <= 100; i++)
            {
                if (N % 2 == 0)
                   {
                    Console.WriteLine(N);
                   }
                N++;
            }
            Console.ReadLine();
        }
    }
}
