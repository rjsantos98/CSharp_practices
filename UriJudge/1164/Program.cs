using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1164NumeroPerfeito
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Y = 0; 

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Y = 1;
                int X = int.Parse(Console.ReadLine());
                while ((Math.Pow(2, Y) * (Math.Pow(2, Y + 1) - 1)) <= X)
                {
                    if ((Math.Pow(2, Y) * (Math.Pow(2, Y + 1) - 1)) == X)
                    {
                        Console.WriteLine(X + " eh perfeito");
                        break;
                    }
                    Y++;
                }
                if ((Math.Pow(2, Y) * (Math.Pow(2, Y + 1) - 1)) != X)
                {
                    Console.WriteLine(X + " nao eh perfeito");
                }
            }
            Console.ReadKey();
        }
    }
}
