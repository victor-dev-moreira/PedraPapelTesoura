using System.Security.Cryptography;



class Program
{
    static void Main(string[] args)
    {
        const int ESCOLHA_PEDRA = 1;
        const int ESCOLHA_PAPEL = 2;
        const int ESCOLHA_TESOURA = 3;

        do
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Jogo Pedra Papel Tesoura");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            Console.WriteLine("---------------------------");

            Console.Write("Qual sua escolha? ");
            int escolhaJogador = int.Parse(Console.ReadLine());


            int escolhaComputador = RandomNumberGenerator.GetInt32(1, 4);

            if (escolhaJogador == escolhaComputador)
            {
                Console.WriteLine("Empate");
                Console.ReadLine();
                break;
            }

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

            Console.WriteLine("---------------------------");
            Console.ReadLine();
        } while (true);

    }
}



