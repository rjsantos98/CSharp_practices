using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escadaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    Console.Write(j<n-i?" ":"#");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
