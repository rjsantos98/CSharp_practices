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
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("N[" + i + "] = " + X.ToString("F4", CultureInfo.InvariantCulture));
                X = X / 2.0;
            }
            Console.ReadLine();
        }
    }
}
