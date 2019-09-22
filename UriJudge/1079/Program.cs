using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Uri1079Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int N; 
            double v1, v2, v3, cont;

            N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                cont = (2*v1 + 3*v2 + 5*v3) / 10;
                Console.WriteLine(cont.ToString("f1", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
