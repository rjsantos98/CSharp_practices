using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, exame, mediaFinal;
            double[] N = new double[4];
            N = Array.ConvertAll(Console.ReadLine().Split(' '), arNotas => Convert.ToDouble(arNotas, CultureInfo.InvariantCulture));
            media = ((N[0] * 2) + (N[1] * 3) + (N[2] * 4) + (N[3] * 1)) / 10;

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }

            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                exame = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("f1", CultureInfo.InvariantCulture));
                mediaFinal = (media + exame) / 2;

                if (mediaFinal >= 5.0) Console.WriteLine("Aluno aprovado.");

                else Console.WriteLine("Aluno reprovado.");

                Console.WriteLine("Media final: " + mediaFinal.ToString("f1", CultureInfo.InvariantCulture));
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            Console.ReadLine();
        }
    }
}
