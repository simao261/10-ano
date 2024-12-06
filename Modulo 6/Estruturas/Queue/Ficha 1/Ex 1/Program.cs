using System;
using System.Collections.Generic;

class FilaDeMusicas
{
    private Queue<string> filaDeMusicas;

    public FilaDeMusicas()
    {
        filaDeMusicas = new Queue<string>();
    }

    public void AdicionarMusica(string musica)
    {
        filaDeMusicas.Enqueue(musica);
        Console.WriteLine($"A música '{musica}' foi adicionada à fila.");
    }

    public void ApagarFila()
    {
        filaDeMusicas.Clear();
        Console.WriteLine("A fila de músicas foi apagada.");
    }

    public int ContarMusicas()
    {
        return filaDeMusicas.Count;
    }

    public bool VerificarMusica(string musica)
    {
        return filaDeMusicas.Contains(musica);
    }

    public void ApresentarMusicas()
    {
        if (filaDeMusicas.Count == 0)
        {
            Console.WriteLine("A fila de músicas está vazia.");
        }
        else
        {
            Console.WriteLine("Músicas na fila:");
            foreach (string musica in filaDeMusicas)
            {
                Console.WriteLine(musica);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        FilaDeMusicas fila = new FilaDeMusicas();
        int opcao;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1- Adicionar uma nova música à fila");
            Console.WriteLine("2- Apagar a fila");
            Console.WriteLine("3- Contar número de músicas na fila");
            Console.WriteLine("4- Verificar se a fila contém determinada música");
            Console.WriteLine("5- Apresentar as músicas");
            Console.WriteLine("6- Sair");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = 0;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o nome da música a ser adicionada:");
                    string musica = Console.ReadLine();
                    fila.AdicionarMusica(musica);
                    break;
                case 2:
                    fila.ApagarFila();
                    break;
                case 3:
                    int numeroDeMusicas = fila.ContarMusicas();
                    Console.WriteLine($"Número de músicas na fila: {numeroDeMusicas}");
                    break;
                case 4:
                    Console.WriteLine("Digite o nome da música a ser verificada:");
                    string musicaVerificacao = Console.ReadLine();
                    bool encontrada = fila.VerificarMusica(musicaVerificacao);
                    if (encontrada)
                    {
                        Console.WriteLine($"A música '{musicaVerificacao}' está na fila.");
                    }
                    else
                    {
                        Console.WriteLine($"A música '{musicaVerificacao}' não está na fila.");
                    }
                    break;
                case 5:
                    fila.ApresentarMusicas();
                    break;
                case 6:
                    Console.WriteLine("Saindo do programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha novamente.");
                    break;
            }

        } while (opcao != 6);
    }
}
