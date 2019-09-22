using System;

namespace TempoDeJogoComMinutos
{
    class Program
    {
        static void Main(string[] args)
        {

            int horaInicial, horaFinal, tempoDeJogo, minutoInicial, minutoFinal, minutoDeDuracao;

            String[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            if (horaInicial > horaFinal && minutoInicial > minutoFinal)
            {
                tempoDeJogo = 24 - horaInicial + horaFinal - 1;
                minutoDeDuracao = 60 - (minutoInicial - minutoFinal);
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S) E " + minutoDeDuracao + " MINUTO(S)");
            }
            else if (horaInicial > horaFinal && minutoInicial <= minutoFinal)
            {
                tempoDeJogo = 24 - horaInicial + horaFinal;
                minutoDeDuracao = minutoFinal - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S) E " + minutoDeDuracao + " MINUTO(S)");
            }
            else if (horaInicial < horaFinal && minutoInicial > minutoFinal)
            {
                tempoDeJogo = (horaFinal - horaInicial) - 1;
                minutoDeDuracao = 60 - (minutoInicial - minutoFinal);
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S) E " + minutoDeDuracao + " MINUTO(S)");
            }
            else if (horaInicial < horaFinal && minutoInicial <= minutoFinal)
            {
                tempoDeJogo = horaFinal - horaInicial;
                minutoDeDuracao = minutoFinal - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S) E " + minutoDeDuracao + " MINUTO(S)");
            }
            else if (horaInicial == horaFinal && minutoInicial > minutoFinal)
            {
                tempoDeJogo = (horaInicial - horaFinal) + 24 - 1;
                minutoDeDuracao = 60 - (minutoInicial - minutoFinal);
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S) E " + minutoDeDuracao + " MINUTO(S)");
            }
            else if (horaInicial == horaFinal && minutoInicial < minutoFinal)
            {
                tempoDeJogo = horaInicial - horaFinal;
                minutoDeDuracao = minutoFinal - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S) E " + minutoDeDuracao + " MINUTO(S)");
            }
            else if (horaInicial == horaFinal && minutoInicial == minutoFinal)
            {
                tempoDeJogo = horaInicial - horaFinal + 24;
                minutoDeDuracao = minutoFinal - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S) E " + minutoDeDuracao + " MINUTO(S)");
            }
            Console.ReadLine();
        }
    }
}

