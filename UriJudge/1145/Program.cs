using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URUI1145SequenciaLogica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i = 1, j;

            String[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (i <= y)
            {
                for (j = 0; j < x; j++)
                {
                    if (i > y)
                    {
                        break;
                    }
                    if (j < x - 1)
                    {
                        Console.Write(i++ + " ");
                    }
                    else
                    {
                        Console.Write(i++);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}