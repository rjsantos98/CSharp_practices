using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1018Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, troco, cem, cinquenta, vinte, dez, cinco, dois, um;

            valor = int.Parse(Console.ReadLine());

            cem = valor / 100;
            cinquenta = ((valor - cem * 100) / 50);
            vinte = ((valor - cem * 100 - cinquenta * 50) / 20);
            dez = ((valor - cem * 100 - cinquenta * 50 - vinte * 20) / 10);
            cinco = ((valor - cem * 100 - cinquenta * 50 - vinte * 20 - dez * 10) / 5);
            dois = ((valor - cem * 100 - cinquenta * 50 - vinte * 20 - dez * 10 - cinco * 5) / 2);
            um = (valor - cem * 100 - cinquenta * 50 - vinte * 20 - dez * 10 - cinco * 5 - dois * 2);


            Console.WriteLine(valor +"");
            Console.WriteLine(cem+" nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta+" nota(s) de R$ 50,00");
            Console.WriteLine(vinte+" nota(s) de R$ 20,00");
            Console.WriteLine(dez+" nota(s) de R$ 10,00");
            Console.WriteLine(cinco+" nota(s) de R$ 5,00");
            Console.WriteLine(dois+" nota(s) de R$ 2,00");
            Console.WriteLine(um+" nota(s) de R$ 1,00");
            Console.ReadKey();
        }
    }
}
