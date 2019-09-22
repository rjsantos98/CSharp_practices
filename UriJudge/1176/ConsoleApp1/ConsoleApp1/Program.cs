using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static long[] vet = new long[1000000];
        static void Main(string[] args)
        {
            vet = FibonacciVetor();

            int h = int.Parse(Console.ReadLine());
            long[] n = new long[h];
            for (int i = 0; i < h; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int c = 0; c < n.Count(); c++)
            {
                if (n[c] == 1 || n[c] == 0)
                {
                    Console.WriteLine($"Fib({n[c]}) = {vet[n[c]]}");
                }
                else
                {
                    Console.WriteLine($"Fib({n[c]}) = {vet[n[c]]}");
                }
            }
            Console.ReadLine();
        }
        static long[] FibonacciVetor()
        {
            long fib = 1, ant = 0;
            for (int c = 0; c < 1000000; c++)
            {
                if (c == 0 || c == 1)
                {
                    vet[c] = c;
                }
                else
                {
                    fib += ant;
                    ant = fib - ant;
                    vet[c] = fib;
                }
            }
            return vet;
        }
    }
}
