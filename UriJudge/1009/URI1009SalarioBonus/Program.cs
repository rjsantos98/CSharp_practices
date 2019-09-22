using System;
using System.Globalization;

namespace URI1009SalarioBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME;
            double BONUS, SALARIO, TOTAL;

            NOME = (Console.ReadLine());
            BONUS = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            TOTAL = (SALARIO * 0.15) + BONUS;

            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadLine();
        }
    }
}