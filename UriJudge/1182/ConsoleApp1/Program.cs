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
            double a = 0.0;
            double[,] M = new double[12, 12];
            char T;
            int C, x, y;
            C = int.Parse(Console.ReadLine());
            T = Convert.ToChar(Console.ReadLine());
            for (x = 0; x <= 11; x++)
            {
                for (y = 0; y <= 11; y++)
                {
                    M[y, x] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (y == C)
                        a += M[y, x];
                }
            }
            if (T == 'S')
                Console.WriteLine(a.ToString("F1", CultureInfo.InvariantCulture));
            else if (T == 'M')
            {
                a = a / 12.0;
                Console.WriteLine(a.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.Read();
        }
    }
}
