using System;

namespace URI1032NULTIPLOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            soma = 0;
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }

            for (int i = min; i < max; i++)
            {
                if (i % 13 != 0)
                {
                    soma = soma + i;

                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }

}