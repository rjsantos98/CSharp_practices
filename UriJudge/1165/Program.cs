using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1165NumerosPrimos
{
    using System;
    namespace desafio8
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n, x, cont;
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    x = int.Parse(Console.ReadLine());
                    cont = 0;
                    if (x == 1)
                        Console.WriteLine(x + " nao eh primo");
                    else
                    {
                        for (int i2 = 1; i2 < x + 1; i2++)
                        {
                            if (x % i2 == 0)
                                cont++;
                        }
                        if (cont > 2)
                            Console.WriteLine(x + " nao eh primo");
                        else
                            Console.WriteLine(x + " eh primo");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}