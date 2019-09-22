using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSum
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long result = 0;
            for(int i=0; i<ar.Length; i++)
            {
                result += ar[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = aVeryBigSum(ar);

            Console.WriteLine(result);

            Console.Read();
        }
    }
}
