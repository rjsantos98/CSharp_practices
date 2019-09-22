using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[15];
            int[] par = new int[5];
            int[] impar = new int[5];
            int countPar = 0;
            int countImpar = 0;
            for (int i = 0; i < 15; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    par[countPar] = x[i];
                    countPar++;
                    if (countPar == 5)
                    {
                        for (int j = 0; j < par.Length; j++)
                        {
                            Console.WriteLine($"par[{j}] = {par[j]}");
                        }
                        par = new int[5];
                        countPar = 0;
                    }
                }
                else
                {
                    impar[countImpar] = x[i];
                    countImpar++;
                    if (countImpar == 5)
                    {
                        for (int j = 0; j < impar.Length; j++)
                        {
                            Console.WriteLine($"impar[{j}] = {impar[j]}");
                        }
                        impar = new int[5];
                        countImpar = 0;
                    }
                }
            }
            for (int j = 0; j < countImpar; j++)
            {
                Console.WriteLine($"impar[{j}] = {impar[j]}");
            }
            for (int i = 0; i<countPar; i++)
            {
                Console.WriteLine($"par[{i}] = {par[i]}");
            }

            Console.ReadLine();
        }
    }
}
