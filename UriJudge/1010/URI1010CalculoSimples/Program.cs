using System;
using System.Globalization;
namespace URI1010CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, quantidadeDePecas1, codigoPeca2, quantidadeDePecas2;
            double valorPeca1, valorPeca2, totalPagar;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vet[0]);
            quantidadeDePecas1 = int.Parse(vet[1]);
            valorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vet[0]);
            quantidadeDePecas2 = int.Parse(vet[1]);
            valorPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            totalPagar = quantidadeDePecas1 * valorPeca1 + quantidadeDePecas2 * valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}