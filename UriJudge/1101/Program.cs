using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1101SequenciaSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 1, N = 1, seq, sum = 0;

            while (M != 0 || N != 0)
            {
                string[] vet = Console.ReadLine().Split(' ');
                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);

                if (M <= 0 || N <= 0)
                {
                    break;
                }

                if (M < N )
                {
                    for(seq=M; seq<=N; seq++)
                    {
                        Console.Write(seq+" ");
                        sum += seq;
                    }
                    Console.WriteLine("Sum="+sum);
                }
                else if (N < M)
                {
                    for (seq=N; seq<=M; seq++)
                    { 
                        Console.Write(seq+" ");
                        sum += seq;
                    }
                    Console.WriteLine("Sum=" + sum);
                }
                sum = 0;
            }
            Console.ReadKey();
          
        }
 
    }
}
