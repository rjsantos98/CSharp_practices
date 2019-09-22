using System;
using System.Globalization;


namespace URI1037Intervalos
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (A >= 0 && A <= 25.00000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (A >= 25.00001 && A <= 50.00000){
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (A >= 50.00001 && A <= 75.00000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (A >= 75.00001 && A <= 100.00000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            Console.ReadKey();
        }
    }
}
