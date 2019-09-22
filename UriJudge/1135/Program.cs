using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace exercicios_UDEMY
{
    class Program
    {
        static void Main(string[] args)
        {
            int COD;
            int C_Alc = 0, C_Gas = 0, C_Diesel = 0;
            COD = int.Parse(Console.ReadLine());
            while (COD != 4)
            {
                switch (COD)
                {
                    case 1: C_Alc++; break;
                    case 2: C_Gas++; break;
                    case 3: C_Diesel++; break;
                }
                COD = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + C_Alc);
            Console.WriteLine("Gasolina: " + C_Gas);
            Console.WriteLine("Diesel: " + C_Diesel);
            Console.ReadLine();
        }
    }
}