using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int count = 0, max = ar.Max();

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = birthdayCakeCandles(ar);

            Console.WriteLine(result);

            Console.Read();
        }
    }
}
