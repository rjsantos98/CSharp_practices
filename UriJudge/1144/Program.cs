using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1144SequenciaLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, N1, N2, N3, N4, N5, N6;
            N1 = N2 = N3 = N4 = N5 = N6 = 0;

            N = double.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                N1 = i;
                N2 = Math.Pow(N1, 2);
                N3 = N1 * N2;

                Console.WriteLine(N1+" "+N2+" "+N3);

                N4 = i;
                N5 = N2 + 1;
                N6 = N3 + 1;

                Console.WriteLine(N4+" "+N5+" "+N6);

            }
            Console.ReadLine();

        }
    }
}

