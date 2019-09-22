using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1075Resto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int cont=1; cont<10000; cont++)
                {
                 if (cont % N == 2) { Console.WriteLine(cont); }
                }
            Console.ReadKey();
        }
    }
}
