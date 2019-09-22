using System;
using System.Globalization;

namespace URI1048Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, nSalario, reajuste, ganho;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (0.00 <= salario && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                nSalario = salario + reajuste;

                Console.WriteLine("Novo salario: " + nSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");

            }
            else if (400.01 <= salario && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                nSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + nSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (800.01 <= salario && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                nSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + nSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (1200.01 <= salario && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                nSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + nSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                reajuste = salario * 0.04;
                nSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + nSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
            Console.ReadLine();

        }
    }
}