using PedraPapelTesoura.ConsoleApp.Entidades;
namespace PedraPapelTesoura;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int escolhaJogador = Jogador.ObterEscolha();

            int escolhaComputador = Computador.ObterEscolha();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            Console.WriteLine("---------------------------");
            Console.Write("Deseja continuar? (S/N)");
            string? desejaContinuar = Console.ReadLine().ToUpper();

            if (desejaContinuar != "S")
                break;
            Console.Read();
        }
    }
}