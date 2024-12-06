using System;
using System.Collections.Generic;

public struct Automovel
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public string Matricula { get; set; }
    public int Ano { get; set; }
    public int Cilindrada { get; set; }
    public double PrecoAluguer { get; set; }
    public bool Disponibilidade { get; set; }
}

class Program
{
    static List<Automovel> automoveis = new List<Automovel>();

    static void Main()
    {
        int opcao;

        do
        {
            MostrarMenu();
            opcao = LerOpcaoMenu();

            switch (opcao)
            {
                case 1:
                    RegistarAutomovel();
                    break;
                case 2:
                    ListarTodosAutomoveis();
                    break;
                case 3:
                    ListagemPorMatricula();
                    break;
                case 4:
                    ContagemDisponiveis();
                    break;
                case 5:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 5);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1 - Registar automóvel");
        Console.WriteLine("2 - Listar todos os automóveis");
        Console.WriteLine("3 - Listagem por matrícula");
        Console.WriteLine("4 - Contagem de automóveis disponíveis");
        Console.WriteLine("5 - Sair");
    }

    static int LerOpcaoMenu()
    {
        Console.Write("\nEscolha uma opção: ");
        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
        {
            Console.Write("Opção inválida. Escolha novamente: ");
        }
        return opcao;
    }

    static void RegistarAutomovel()
    {
        Automovel novoAutomovel = new Automovel();

        Console.WriteLine("\nRegistar novo automóvel:");

        Console.Write("Marca: ");
        novoAutomovel.Marca = Console.ReadLine();

        Console.Write("Modelo: ");
        novoAutomovel.Modelo = Console.ReadLine();

        Console.Write("Cor: ");
        novoAutomovel.Cor = Console.ReadLine();

        Console.Write("Matrícula: ");
        novoAutomovel.Matricula = Console.ReadLine();

        Console.Write("Ano: ");
        novoAutomovel.Ano = int.Parse(Console.ReadLine());

        Console.Write("Cilindrada: ");
        novoAutomovel.Cilindrada = int.Parse(Console.ReadLine());

        Console.Write("Preço de aluguer: ");
        novoAutomovel.PrecoAluguer = double.Parse(Console.ReadLine());

        Console.Write("Disponível para aluguer (true/false): ");
        novoAutomovel.Disponibilidade = bool.Parse(Console.ReadLine());

        automoveis.Add(novoAutomovel);

        Console.WriteLine("Automóvel registado com sucesso.");
    }

    static void ListarTodosAutomoveis()
    {
        Console.WriteLine("\nListagem de todos os automóveis:");

        if (automoveis.Count == 0)
        {
            Console.WriteLine("Não há automóveis registados.");
            return;
        }

        foreach (var automovel in automoveis)
        {
            MostrarDetalhesAutomovel(automovel);
        }
    }

    static void ListagemPorMatricula()
    {
        Console.Write("\nDigite a matrícula do automóvel que deseja procurar: ");
        string matricula = Console.ReadLine();

        bool encontrou = false;

        foreach (var automovel in automoveis)
        {
            if (automovel.Matricula.Equals(matricula, StringComparison.OrdinalIgnoreCase))
            {
                MostrarDetalhesAutomovel(automovel);
                encontrou = true;
                break;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine($"Não foi encontrado nenhum automóvel com a matrícula '{matricula}'.");
        }
    }

    static void ContagemDisponiveis()
    {
        int contador = 0;

        foreach (var automovel in automoveis)
        {
            if (automovel.Disponibilidade)
            {
                contador++;
            }
        }

        Console.WriteLine($"\nNúmero de automóveis disponíveis para aluguer: {contador}");
    }

    static void MostrarDetalhesAutomovel(Automovel automovel)
    {
        Console.WriteLine("\nDetalhes do automóvel:");
        Console.WriteLine($"Marca: {automovel.Marca}");
        Console.WriteLine($"Modelo: {automovel.Modelo}");
        Console.WriteLine($"Cor: {automovel.Cor}");
        Console.WriteLine($"Matrícula: {automovel.Matricula}");
        Console.WriteLine($"Ano: {automovel.Ano}");
        Console.WriteLine($"Cilindrada: {automovel.Cilindrada}");
        Console.WriteLine($"Preço de aluguer: {automovel.PrecoAluguer}");
        Console.WriteLine($"Disponibilidade: {(automovel.Disponibilidade ? "Disponível" : "Indisponível")}");
    }
}
