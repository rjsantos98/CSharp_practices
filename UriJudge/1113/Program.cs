using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1113EstruturaEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] vet = Console.ReadLine().Split (' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
            Console.ReadLine();
        }
    }
}
