using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1155WSequenciaS{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1.0;

            for (double i = 2; i <= 100; i++)
            {
                S += 1.0 / i;
            }
            Console.WriteLine(S.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }

    }
}    

