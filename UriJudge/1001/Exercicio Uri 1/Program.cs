using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Uri_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;
            
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = " + X);

            Console.ReadLine();
        }
    }
}
