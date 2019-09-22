using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*
         * Complete the simpleArraySum function below.
         */
        static int simpleArraySum(int[] ar)
        {
            int num = 0;
            for (int i =0; i<ar.Length; i++)
            {
                num += ar[i];
            } 
            return num;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            Console.WriteLine("Digite o número da matriz: ");
            int arCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite os inteiros para completar a Matriz: ");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar);
            Console.WriteLine();
            Console.WriteLine("Resultado: " +result);

            Console.ReadLine();
        }
    }
}
