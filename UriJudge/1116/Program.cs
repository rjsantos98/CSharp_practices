using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1116Dividindo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double div, x, y;

            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0]);
                y = double.Parse(vet[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    div = x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadKey();
        }
    }
}
