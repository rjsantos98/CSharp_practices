using System;
using System.Globalization;

namespace URI1008Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, HORAS;
            double VALORPORHORA, SALARY;

            NUMBER = int.Parse(Console.ReadLine());
            HORAS = int.Parse(Console.ReadLine());
            VALORPORHORA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            SALARY = HORAS * VALORPORHORA;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadLine();
        }
    }
}
