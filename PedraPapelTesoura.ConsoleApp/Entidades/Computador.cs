using System.Security.Cryptography;
namespace PedraPapelTesoura.ConsoleApp.Entidades;

public class Computador
{
    public static int ObterEscolha()
    {
        int escolhaComputador = RandomNumberGenerator.GetInt32(1, 4);

        return escolhaComputador;
    }
}
