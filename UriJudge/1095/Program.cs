using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1095Sequencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, J;

            for (I = 1, J = 60; J >= 0; J -= 5)
            {
                Console.WriteLine("I=" + I + " J=" + J);
                I += 3;
            }
        Console.ReadLine();
        }
    }
}

