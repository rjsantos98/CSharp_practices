using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1011Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double RAIO, VOLUME;

            RAIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            VOLUME = (4.0 / 3.0) * 3.14159 * RAIO * RAIO * RAIO;

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
