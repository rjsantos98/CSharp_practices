using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1013OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MaiorAB;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            MaiorAB = (A+B+Math.Abs(A-B))/2;
            MaiorAB = (MaiorAB+C+Math.Abs(MaiorAB-C))/2; 

            Console.WriteLine(MaiorAB+ " eh o maior" );

            Console.ReadLine();
        }
    }
}

