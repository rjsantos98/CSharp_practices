using System;
using System.Globalization;

namespace URI1061Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z, hh_inicio, mm_inicio, ss_inicio, hh_fim, mm_fim, ss_fim, dia_inicio, dia_fim, calculo_inicio, calculo_final, total_tempo;
            string[] vet;


            dia_inicio = int.Parse(Console.ReadLine());
            vet = Console.ReadLine().Split(':');
            hh_inicio = int.Parse(vet[0]);
            mm_inicio = int.Parse(vet[1]);
            ss_inicio = int.Parse(vet[2]);
            dia_fim = int.Parse(Console.ReadLine());
            vet = Console.ReadLine().Split(':');
            hh_fim = int.Parse(vet[0]);
            mm_fim = int.Parse(vet[1]);
            ss_fim = int.Parse(vet[2]);

            calculo_inicio = ss_inicio + mm_inicio * 60 + hh_inicio * 3600 + dia_inicio * 86400;
            calculo_final = ss_fim + mm_fim * 60 + hh_fim * 3600 + dia_fim * 86400;
            total_tempo = calculo_final - calculo_inicio;

            w = total_tempo / 86400;
            x = total_tempo % 86400 / 3600;
            y = total_tempo % 86400 % 3600 / 60;
            z = total_tempo % 86400 % 3600 % 60;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(y + " minuto(s)");
            Console.WriteLine(z + " segundo(s)");

            Console.ReadLine();

        }
    }
}