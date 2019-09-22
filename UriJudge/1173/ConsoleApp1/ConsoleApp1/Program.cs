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
            N[0] = int.Parse(Console.ReadLine());

            for (int j = 0; j < 10; j++)
            {
                if (N[j] == N[0]) Console.WriteLine($"N[{j}] = {N[j]}");
                else {
                    N[j] = N[j - 1] * 2;
                    Console.WriteLine($"N[{j}] = {N[j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
