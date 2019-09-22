using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1094Experiencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quantia, coelho, rato, sapo; 
            double perC, perS, perR, total;
            char tipo;
            sapo = 0;
            coelho = 0;
            rato = 0;
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                quantia = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);

                if (tipo == 'S')
                {
                    sapo += quantia;
                }

                if (tipo == 'R')
                {
                    rato += quantia;
                }

                if (tipo == 'C')
                {
                    coelho += quantia;
                }

            }
            total = coelho + sapo + rato;
            perC = (coelho * 100) / total;
            perS = (sapo * 100) / total;
            perR = (rato * 100) / total;
            Console.WriteLine("Total: " + total.ToString("F0", CultureInfo.InvariantCulture) +" cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " +perC.ToString("F2", CultureInfo.InvariantCulture)+ " %");
            Console.WriteLine("Percentual de ratos: " + perR.ToString("F2", CultureInfo.InvariantCulture)+ " %");
            Console.WriteLine("Percentual de sapos: " + perS.ToString("F2", CultureInfo.InvariantCulture)+ " %");
            Console.Read();
        }
    }
}
