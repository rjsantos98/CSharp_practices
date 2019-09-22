using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1146SequenciasCrescentes
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 1;

            while (X > 0)
            {
                X = int.Parse(Console.ReadLine());
                for (int i = 1; i <= X; i++)
                {
                    if (i == X)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    Console.Write(i+" ");
                }

            }
            Console.ReadLine();
        }
    }
}
