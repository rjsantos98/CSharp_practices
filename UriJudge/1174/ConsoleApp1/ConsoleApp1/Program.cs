using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[100];

            for(int i = 0; i<100; i++)
            {
                A[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int j = 0; j <A.Count(); j++)
            {
                if (A[j] <= 10) Console.WriteLine($"A[{j}] = {A[j].ToString("f1", CultureInfo.InvariantCulture)}");
            }
            Console.ReadLine();
        }
    }
}
