using System;

namespace URI1142PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4 * X; i++)
            {
                if (i % 4 != 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine("PUM");
                }
            }
            Console.ReadKey();
        }
    }
}

