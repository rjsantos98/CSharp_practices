using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            long min = 0, max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min += arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                max += arr[i];
            }
            min -= arr.Max();
            max -= arr.Min();
            Console.Write($"{min} {max}");
            Console.Read();
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
