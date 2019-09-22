using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main2(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            long[] n = new long[h];
            long fib = 1, ant = 0;
            for (int i = 0; i < h; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int c = 0; c < n.Count(); c++)
            {
                if (n[c] == 1 || n[c] == 0)
                {
                    Console.WriteLine($"Fib({n[c]}) = {n[c]}");
                }
                else
                {
                    for (int j = 1; j < n[c]; j++)
                    {
                        fib += ant;
                        ant = fib - ant;
                    }
                    Console.WriteLine($"Fib({n[c]}) = {fib}");
                }
                fib = 1;
                ant = 0;
            }
            Console.ReadLine();
        }
    }
}