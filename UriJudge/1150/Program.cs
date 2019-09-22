using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1150Ultrapassando
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Soma, Cont;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            while (B <= A)
            {
                B = int.Parse(Console.ReadLine());
            }

            Soma = 0;
            Cont = 0;

            if (A < 0)
            {
                for (int i = A; i <= B; i++)
                {
                    A += 1;
                    Cont++;

                    if (i > 0)
                    {
                        Soma += i;

                        if (Soma > B)
                        {
                            i = Soma;
                        }
                    }
                }
            }
            else
            {
                for (int i = A; i < B; i++)
                {
                    Soma += i;
                    Cont++;

                    if (Soma > B)
                    {
                        i = Soma;
                    }
                }
            }
            Console.WriteLine(Cont);
        }
    }
}