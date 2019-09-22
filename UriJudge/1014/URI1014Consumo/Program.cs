using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1014Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, consumo;

            X = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) +" km/l");
            Console.ReadKey();
        }
    }
}
