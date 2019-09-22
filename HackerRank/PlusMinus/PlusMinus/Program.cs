using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PlusMinus
{
    class Program
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            decimal positive = 0, negative = 0, zero = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    negative++;
                }
                else if(arr[i] > 0)
                {
                    positive++;
                }
                else if(arr[i] == 0)
                {
                    zero++;
                }
            }
            decimal resultPos = positive / arr.Length;
            decimal resultNeg =  negative/arr.Length;
            decimal resultZer = zero / arr.Length;
            Console.WriteLine(resultPos.ToString("F6"), CultureInfo.InvariantCulture);
            Console.WriteLine(resultNeg.ToString("F6"), CultureInfo.InvariantCulture);
            Console.WriteLine(resultZer.ToString("F6"), CultureInfo.InvariantCulture);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            plusMinus(arr);
        }
    }
}

