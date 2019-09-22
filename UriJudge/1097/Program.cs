
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1097Sequencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, J;

            for (I = 1, J = 7; I <= 9; I += 2)
            {
                Console.WriteLine("I=" + I + " J=" + J);
                if (J != 5)
                {
                    J -= 1;
                    Console.WriteLine("I=" + I + " J=" + J);
                }
                if (J != 5)
                {
                    J -= 1;
                    Console.WriteLine("I=" + I + " J=" + J);
                }
                J += 4;
            }
            Console.ReadLine();
        }
    }
}


