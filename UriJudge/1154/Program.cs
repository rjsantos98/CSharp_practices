using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI11154Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont; 
            double   media, soma;
            idade = int.Parse(Console.ReadLine());
            soma = 0;
            cont = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
