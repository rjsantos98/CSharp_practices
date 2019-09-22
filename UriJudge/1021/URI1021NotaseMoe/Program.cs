using System;
using System.Globalization;

namespace URI1021NotaseMoe
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int n100, n50, n20, n10, n5, n2, m100, m050, m025, m010, m005, m001;
            int resto100, resto50, resto20, resto10, resto5, resto2, resto1, resto050, resto025, resto010, resto005, resto001;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            N = N * 100;

            n100 = (int)N / 10000;
            resto100 = (int)N % 10000;

            n50 = (int)resto100 / 5000;
            resto50 = resto100 % 5000;

            n20 = (int)resto50 / 2000;
            resto20 = resto50 % 2000;

            n10 = (int)resto20 / 1000;
            resto10 = resto20 % 1000;

            n5 = (int)resto10 / 500;
            resto5 = resto10 % 500;

            n2 = (int)resto5 / 200;
            resto2 = resto5 % 200;

            m100 = (int)resto2 / 100;
            resto1 = resto2 % 100;

            m050 = (int)resto1 / 50;
            resto050 = resto1 % 50;

            m025 = (int)resto050 / 25;
            resto025 = resto050 % 25;

            m010 = (int)resto025 / 10;
            resto010 = resto025 % 10;

            m005 = (int)resto010 / 5;
            resto005 = resto010 % 5;

            m001 = (int)resto005 / 1;
            resto001 = resto005 % 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m100 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m050 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m025 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m010 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m005 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m001 + " moeda(s) de R$ 0.01");

            Console.ReadLine();
        }
    }
}