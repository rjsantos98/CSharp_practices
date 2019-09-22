
using System;
using System.Globalization;
class URI1099Impares
{
    static void Main(string[] args)
    {
        int n,x, y, min = 0, max = 0, sum = 0;

        n = int.Parse(Console.ReadLine());

        for (int j = 0; j < n; j++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            if (x < y || x == y)
            {
                min = x;
                max = y;
            }
            else if (y < x || y == x)
            {
                min = y;
                max = x;
            }
            for (int i = min + 1; i < max; i++) { 
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            sum = 0;
        }
        Console.ReadKey();
    }
}