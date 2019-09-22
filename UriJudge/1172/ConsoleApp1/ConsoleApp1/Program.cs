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
            int[] N = new int[10];
            for (int i = 0; i < 10; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }
            for(int j = 0; j < N.Count(); j++)
            {
                if (N[j] <= 0) Console.WriteLine($"X[{j}] = 1");
                else Console.WriteLine($"X[{j}] = {N[j]}");
            }
            Console.ReadLine();
        }
    }
}
