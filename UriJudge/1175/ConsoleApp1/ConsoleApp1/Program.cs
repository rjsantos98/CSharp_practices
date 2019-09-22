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
            int[] N = new int[20];
            int h = 19;
            for (int i = 0; i < 20; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }
            for (int g = 0; g < N.Length; g++)
            {
                Console.WriteLine("N["+ g +"] = " +N[h]);
                h--;
            }
            Console.ReadLine();
        }
    }
}
