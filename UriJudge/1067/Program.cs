using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1067Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i+=2 )
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
