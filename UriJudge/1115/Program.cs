using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1115QUADRANTE
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] vet = Console.ReadLine().Split(' ');

            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            while (X != 0 && Y !=0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    Console.WriteLine();
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}
