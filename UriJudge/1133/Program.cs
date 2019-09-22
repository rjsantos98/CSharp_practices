using System;
using System.Globalization;
namespace URI1133RESTODIVISAO
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, menor, maior, divisao;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                menor = y;
                maior = x;
            }
            else
            {
                menor = x;
                maior = y;
            }

            for (int i = menor + 1; i < maior; i++)
            {
                if ((i % 5) == 2 || (i % 5) == 3)
                {
                    divisao = i;
                    Console.WriteLine(divisao);
                }
            }
        }
    }
}