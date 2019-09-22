using System;
using System.Globalization;
namespace URI1051Imposto
{
    class Program
    {
        static void Main(string[] args)

        {

            double salario, imposto;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 4500.00)

            {

                imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;

                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

            }

            else if (salario > 3000.00)

            {

                imposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;

                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

            }

            else if (salario > 2000.00)

            {

                imposto = (salario - 2000.00) * 0.08;

                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

            }

            else if (salario > 0.0 && salario < 2000.00)
            {
                Console.WriteLine("Isento");
            }
            Console.ReadLine();
        }
    }
}


