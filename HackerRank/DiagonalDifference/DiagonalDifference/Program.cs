using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int result1 = 0;
            int result2 = 0;
            int resultEnd = 0;
            for (int i=arr.Count - 1; i > 0; i--)
            {

                for (int j=0; j<arr.Count; j++)
                {
                    result1 += arr[j][j];
                    result2 += arr[j][i];
                    i--;
                }
            }
            resultEnd = Math.Abs(result1 - result2);
            return resultEnd;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Program.diagonalDifference(arr);

            Console.Write(result);

            Console.Read();
        }
    }

}
