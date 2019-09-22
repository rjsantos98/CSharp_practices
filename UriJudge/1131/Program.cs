using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int TOTAL_GRENAL = 0, NOVO_GRENAL = 1, GOL_GREMIO, GOL_INTER, GRENAL_GREMIO = 0, GRENAL_INTER = 0, EMPATE = 0;
            string[] vet;

            while (NOVO_GRENAL != 2)
            {

                vet = Console.ReadLine().Split(' ');
                GOL_INTER = int.Parse(vet[0]);
                GOL_GREMIO = int.Parse(vet[1]);
                TOTAL_GRENAL += 1;

                if (GOL_INTER > GOL_GREMIO)
                {
                    GRENAL_INTER += 1;
                }
                if (GOL_GREMIO > GOL_INTER)
                {
                    GRENAL_GREMIO += 1;
                }
                if (GOL_GREMIO == GOL_INTER)
                {
                    EMPATE += 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                NOVO_GRENAL = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(TOTAL_GRENAL + " grenais");
            Console.WriteLine("Inter:" + GRENAL_INTER);
            Console.WriteLine("Gremio:" + GRENAL_GREMIO);
            Console.WriteLine("Empates:" + EMPATE);
            if (GRENAL_GREMIO > GRENAL_INTER)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            if (GRENAL_INTER > GRENAL_GREMIO)
            {
                Console.WriteLine("Inter venceu mais");
            }
            if (GRENAL_GREMIO == GRENAL_INTER)
            {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}