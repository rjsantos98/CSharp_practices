using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, PROD;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine("PROD = " + PROD);
            Console.ReadLine();
        }
    }
}
