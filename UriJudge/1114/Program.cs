using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1114SenhaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            Console.ReadLine();
        }
    }
}
