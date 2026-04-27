using System;

namespace PedraPapelTesoura.ConsoleApp.Entidades;

public class Jogo
{
    const int ESCOLHA_PEDRA = 1;
    const int ESCOLHA_PAPEL = 2;
    const int ESCOLHA_TESOURA = 3;
    public static void CompararEscolhas(int escolhaJogador, int escolhaComputador)
    {
        if (escolhaJogador == escolhaComputador)
        {
            Console.WriteLine("Empate");

        }
        else if (escolhaJogador == 1 || escolhaJogador == 2 || escolhaJogador == 3)
        {
            if (escolhaJogador == ESCOLHA_PEDRA)
            {
                Console.Write("Pedra vs ");
                if (escolhaComputador == ESCOLHA_PAPEL)
                {
                    Console.WriteLine("Papel");
                    Console.WriteLine("Computador Venceu");

                }
                else if (escolhaComputador == ESCOLHA_TESOURA)
                {
                    Console.WriteLine("Tesoura");
                    Console.WriteLine("Jogador Venceu");
                }
            }

            if (escolhaJogador == ESCOLHA_PAPEL)
            {
                Console.Write("Papel vs ");

                if (escolhaComputador == ESCOLHA_PEDRA)
                {
                    Console.WriteLine("Pedra");
                    Console.WriteLine("Jogador Venceu");

                }
                else if (escolhaComputador == ESCOLHA_TESOURA)
                {
                    Console.WriteLine("Tesoura");
                    Console.WriteLine("Computador Venceu");
                }
            }

            if (escolhaJogador == ESCOLHA_TESOURA)
            {
                Console.Write("Tesoura vs ");

                if (escolhaComputador == ESCOLHA_PEDRA)
                {
                    Console.WriteLine("Pedra");
                    Console.WriteLine("Computador Venceu");

                }
                else if (escolhaComputador == ESCOLHA_PAPEL)
                {
                    Console.WriteLine("Papel");
                    Console.WriteLine("Jogador Venceu");
                }
            }
        }
    }
}
