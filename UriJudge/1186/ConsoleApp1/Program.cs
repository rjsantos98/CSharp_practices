using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0;
            double[,] M = new double[12, 12];
            char O;
            O = Convert.ToChar(Console.ReadLine());
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    M[x, y] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (x + y > 11)
                    {
                        soma += M[x, y];
                    }
                }
            }
            if (O == 'S')
                Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
            else if (O == 'M')
            {
                soma = soma / 66.0;
                Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.Read();
        }
    }
}
