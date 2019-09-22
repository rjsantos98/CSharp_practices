using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1160CrescimentoPopulacional
{
namespace exercicio1160
{
        class Program
        {
            static void Main(string[] args)
            {
                int i, j, T;
                double PA, PB, G1, G2;

                T = int.Parse(Console.ReadLine());

                for (i = 1; i <= T; i++)
                {
                    string[] vet = Console.ReadLine().Split(' ');
                    PA = double.Parse(vet[0]);
                    PB = double.Parse(vet[1]);
                    G1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                    G2 = double.Parse(vet[3], CultureInfo.InvariantCulture);


                    j = 0;
                    while (j <= 100 && PA <= PB)
                    {
                        PA = (int)(PA * (100.0 + G1) / 100.0);
                        PB = (int)(PB * (100.0 + G2) / 100.0);
                        j++;
                    }
                    if (j <= 100)
                    {
                        Console.WriteLine(j + " anos.");
                    }
                    else
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
