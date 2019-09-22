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
            int T = int.Parse(Console.ReadLine());
            int count = 0;
            long[] N = new long[1000];
            do
            {
                for (int i = 0; i < T; i++)
                {
                    if(count == 1000)
                    {
                        break;
                    }
                    N[count] = i;
                    Console.WriteLine($"N[{count}] = {N[count]}");
                    count++;
                }
            } while (count <= 999);
            Console.ReadLine();
        }
    }
}
