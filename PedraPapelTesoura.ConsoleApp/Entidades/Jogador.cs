using System.Security.Cryptography;
namespace PedraPapelTesoura.ConsoleApp.Entidades;

public class Jogador
{
    public static int ObterEscolha()
    {
        int escolhaJogador;
        int escolhaComputador;

        Console.Clear();
        Console.WriteLine("---------------------------");
        Console.WriteLine("Jogo Pedra Papel Tesoura");
        Console.WriteLine("---------------------------");
        Console.WriteLine("1 - Pedra");
        Console.WriteLine("2 - Papel");
        Console.WriteLine("3 - Tesoura");
        Console.WriteLine("---------------------------");

        Console.Write("Qual sua escolha? ");
        escolhaJogador = int.Parse(Console.ReadLine());

        return escolhaJogador;
    }
}