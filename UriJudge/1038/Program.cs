using System;
using System.Globalization;


namespace URI1037Intervalos
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            double valor,total;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            switch (A) {
                case 1:
                    valor = (4.00);
                    break;
                case 2:
                    valor = (4.50);
                    break;
                case 3:
                    valor = (5.00);
                    break;
                case 4:
                    valor = (2.00);
                    break;
                default:
                    valor = (1.50);
                    break;
            }
            total = B * valor;
            {
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}

