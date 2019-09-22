using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1156SequenciaS2
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1.0, fat = 2, soma=2;

            for (double i = 3; i <= 39; i+=2)
            {
                S += i / soma;
                soma *= 2;
            }
            Console.WriteLine(S.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }

    }
}