using System;

namespace URI1143QuadradoaoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, a, b, c; 
                N = int.Parse(Console.ReadLine());
            for (a = 1; a <= N; a++)
            {
                b = a * a;
                c = a * a * a;
                    Console.WriteLine(a+" "+b+" "+c);
                
            }
            Console.ReadLine();
        }
    }
}

