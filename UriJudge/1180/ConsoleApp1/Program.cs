using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            x = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => int.Parse(arTemp));
            int menor = x.Min(), pos = 0;

            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] == menor)
                {
                    pos = i;
                    break;
                }
            }
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + pos);
            Console.ReadLine();
        }
    }
}
