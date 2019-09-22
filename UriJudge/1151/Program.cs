using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1151Fibonnaccifacil
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, d1 = 0, d2 = 1, rest = 0;

            n = int.Parse(Console.ReadLine());

            Console.Write(d1 + " " + d2);
            for (int i = 0; i < n - 2; i++)
            {
                rest = d1 + d2;
                d1 = d2;
                d2 = rest;

                Console.Write(" " + rest);
            }
            Console.WriteLine();
        }
    }
}