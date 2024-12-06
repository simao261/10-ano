using System;
using System.Collections.Generic;

class Musica
{
    public string Nome { get; set; }
    public string CantorOuGrupo { get; set; }
    public int Ano { get; set; }

    public Musica(string nome, string cantorOuGrupo, int ano)
    {
        Nome = nome;
        CantorOuGrupo = cantorOuGrupo;
        Ano = ano;
    }
}

class FilaDeMusicas
{
    private Queue<Musica> filaDeMusicas;

    public FilaDeMusicas()
    {
        filaDeMusicas = new Queue<Musica>();
    }

    public void AdicionarMusica(string nome, string cantorOuGrupo, int ano)
    {
        Musica novaMusica = new Musica(nome, cantorOuGrupo, ano);
        filaDeMusicas.Enqueue(novaMusica);
        Console.WriteLine($"A música '{nome}' de '{cantorOuGrupo}', ano {ano}, foi adicionada à fila.");
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

    public bool VerificarMusica(string nomeMusica)
    {
        foreach (Musica musica in filaDeMusicas)
        {
            if (musica.Nome.Equals(nomeMusica, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
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
            foreach (Musica musica in filaDeMusicas)
            {
                Console.WriteLine($"Nome: {musica.Nome}, Cantor/Grupo: {musica.CantorOuGrupo}, Ano: {musica.Ano}");
            }
        }
    }

    public void ApresentarMusicasPorCantorOuGrupo(string cantorOuGrupo)
    {
        bool encontrou = false;
        foreach (Musica musica in filaDeMusicas)
        {
            if (musica.CantorOuGrupo.Equals(cantorOuGrupo, StringComparison.OrdinalIgnoreCase))
            {
                if (!encontrou)
                {
                    Console.WriteLine($"Músicas do Cantor/Grupo '{cantorOuGrupo}':");
                    encontrou = true;
                }
                Console.WriteLine($"Nome: {musica.Nome}, Ano: {musica.Ano}");
            }
        }
        if (!encontrou)
        {
            Console.WriteLine($"Não foram encontradas músicas do Cantor/Grupo '{cantorOuGrupo}'.");
        }
    }

    public void ApresentarMusicasPorAno(int ano)
    {
        bool encontrou = false;
        foreach (Musica musica in filaDeMusicas)
        {
            if (musica.Ano == ano)
            {
                if (!encontrou)
                {
                    Console.WriteLine($"Músicas do ano {ano}:");
                    encontrou = true;
                }
                Console.WriteLine($"Nome: {musica.Nome}, Cantor/Grupo: {musica.CantorOuGrupo}");
            }
        }
        if (!encontrou)
        {
            Console.WriteLine($"Não foram encontradas músicas do ano {ano}.");
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
            Console.WriteLine("5- Apresentar as músicas de um cantor/grupo");
            Console.WriteLine("6- Apresentar as músicas de um determinado ano");
            Console.WriteLine("7- Apresentar as músicas");
            Console.WriteLine("8- Sair");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = 0;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o nome da música:");
                    string nomeMusica = Console.ReadLine();
                    Console.WriteLine("Digite o cantor ou grupo da música:");
                    string cantorOuGrupo = Console.ReadLine();
                    Console.WriteLine("Digite o ano da música:");
                    int ano;
                    while (!int.TryParse(Console.ReadLine(), out ano))
                    {
                        Console.WriteLine("Ano inválido. Digite novamente:");
                    }
                    fila.AdicionarMusica(nomeMusica, cantorOuGrupo, ano);
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
                    string nomeVerificacao = Console.ReadLine();
                    bool encontrada = fila.VerificarMusica(nomeVerificacao);
                    if (encontrada)
                    {
                        Console.WriteLine($"A música '{nomeVerificacao}' está na fila.");
                    }
                    else
                    {
                        Console.WriteLine($"A música '{nomeVerificacao}' não está na fila.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Digite o nome do Cantor/Grupo para listar suas músicas:");
                    string nomeCantorGrupo = Console.ReadLine();
                    fila.ApresentarMusicasPorCantorOuGrupo(nomeCantorGrupo);
                    break;
                case 6:
                    Console.WriteLine("Digite o ano para listar as músicas desse ano:");
                    int anoParaListar;
                    while (!int.TryParse(Console.ReadLine(), out anoParaListar))
                    {
                        Console.WriteLine("Ano inválido. Digite novamente:");
                    }
                    fila.ApresentarMusicasPorAno(anoParaListar);
                    break;
                case 7:
                    fila.ApresentarMusicas();
                    break;
                case 8:
                    Console.WriteLine("Saindo do programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha novamente.");
                    break;
            }

        } while (opcao != 8);
    }
}
