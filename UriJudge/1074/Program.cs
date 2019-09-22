using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1074ParouImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X;

            N = int.Parse(Console.ReadLine());
            while (N > 10000)
            {
                N = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X == 0) { Console.WriteLine("NULL"); }
                else if (X % 2 != 0 && X > 0) { Console.WriteLine("ODD POSITIVE"); }
                else if (X % 2 == 0 && X > 0) { Console.WriteLine("EVEN POSITIVE"); }
                else if (X % 2 != 0 && X < 0) { Console.WriteLine("ODD NEGATIVE"); }
                else if (X % 2 == 0 && X < 0) { Console.WriteLine("EVEN NEGATIVE"); }
            }


            Console.ReadKey();
        }
    }
}
