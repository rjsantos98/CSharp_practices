using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1020Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, anos, meses, dias;

            n = int.Parse(Console.ReadLine());

            anos = n / 365;
            meses = ((n - anos * 365) / 30);
            dias = ((n - anos * 365 - meses * 30));


            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadKey();
        }
    }
}

