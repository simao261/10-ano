using System;
using System.Collections.Generic;

public struct Automovel
{
    public string Marca;
    public string Modelo;
    public string Cor;
    public string  Matricula;
    public int Ano;
    public int Cilindrada;
    public decimal PrecoAluguer;
    public bool Disponibilidade;
}

public class Program
{
    static List<Automovel> listaAutomoveis = new List<Automovel>();

    public static void Main()
    {
        int opcao;
        do
        {
            ExibirMenu();
            opcao = ObterOpcaoDoUtilizador();

            switch (opcao)
            {
                case 1:
                    RegistarAutomovel();
                    break;
                case 2:
                    ListarTodos();
                    break;
                case 3:
                    ListagemPorMatricula();
                    break;
                case 4:
                    ContagemDisponiveis();
                    break;
                case 5:
                    PrecoMaxMinMedia();
                    break;
                case 6:
                    ValorFrota();
                    break;
                case 7:
                    Console.WriteLine("A sair...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 7)
            {
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 7);
    }

    public static void RegistarAutomovel()
    {
        Console.Clear();
        Console.WriteLine("Registar Automóvel");
        Automovel auto = new Automovel();

        auto.Marca = ObterEntradaString("Marca: ");
        auto.Modelo = ObterEntradaString("Modelo: ");
        auto.Cor = ObterEntradaString("Cor: ");
        auto.Matricula = ObterEntradaString("Matrícula: ");
        auto.Ano = ObterEntradaInt("Ano: ");
        auto.Cilindrada = ObterEntradaInt("Cilindrada: ");
        auto.PrecoAluguer = ObterEntradaDecimal("Preço de Aluguer: ");
        auto.Disponibilidade = ObterEntradaDisponibilidade("Disponibilidade (1 - Disponível, 0 - Indisponível): ");

        listaAutomoveis.Add(auto);
        Console.WriteLine("Automóvel registado com sucesso!");
    }

    public static void ListarTodos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Todos os Automóveis");
        foreach (var auto in listaAutomoveis)
        {
            ExibirDadosAutomovel(auto);
        }
    }

    public static void ListagemPorMatricula()
    {
        Console.Clear();
        string matricula = ObterEntradaString("Digite a matrícula do automóvel: ");

        bool encontrado = false;
        foreach (var auto in listaAutomoveis)
        {
            if (auto.Matricula == matricula)
            {
                ExibirDadosAutomovel(auto);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Automóvel não encontrado.");
        }
    }

    public static void ContagemDisponiveis()
    {
        Console.Clear();
        int count = 0;
        foreach (var auto in listaAutomoveis)
        {
            if (auto.Disponibilidade)
            {
                count++;
            }
        }
        Console.WriteLine($"Número de automóveis disponíveis: {count}");
    }

    public static void PrecoMaxMinMedia()
    {
        Console.Clear();
        if (listaAutomoveis.Count > 0)
        {
            decimal max = decimal.MinValue;
            decimal min = decimal.MaxValue;
            decimal soma = 0;

            foreach (var auto in listaAutomoveis)
            {
                if (auto.PrecoAluguer > max)
                {
                    max = auto.PrecoAluguer;
                }

                if (auto.PrecoAluguer < min)
                {
                    min = auto.PrecoAluguer;
                }

                soma += auto.PrecoAluguer;
            }

            decimal media = soma / listaAutomoveis.Count;

            Console.WriteLine($"Preço máximo: {max}, Preço mínimo: {min}, Média dos preços: {media}");
        }
        else
        {
            Console.WriteLine("Não há automóveis registados.");
        }
    }

    public static void ValorFrota()
    {
        Console.Clear();
        decimal valorTotal = 0;

        foreach (var auto in listaAutomoveis)
        {
            valorTotal += auto.PrecoAluguer;
        }

        Console.WriteLine($"Valor total da frota de automóveis: {valorTotal} euros");
    }

    public static void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu de Gestão de Automóveis de Aluguer");
        Console.WriteLine("1. Registar automóvel");
        Console.WriteLine("2. Listar todos");
        Console.WriteLine("3. Listagem por matrícula");
        Console.WriteLine("4. Contagem de disponíveis");
        Console.WriteLine("5. Preço máximo, preço mínimo e média dos preços");
        Console.WriteLine("6. Valor em euros da frota de automóveis");
        Console.WriteLine("7. Sair");
    }

    public static int ObterOpcaoDoUtilizador()
    {
        Console.Write("Escolha uma opção: ");
        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            Console.Write("Escolha uma opção: ");
        }
        return opcao;
    }

    public static string ObterEntradaString(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine();
    }

    public static int ObterEntradaInt(string mensagem)
    {
        int valor;
        Console.Write(mensagem);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            Console.Write(mensagem);
        }
        return valor;
    }

    public static decimal ObterEntradaDecimal(string mensagem)
    {
        decimal valor;
        Console.Write(mensagem);
        while (!decimal.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número decimal.");
            Console.Write(mensagem);
        }
        return valor;
    }

    public static bool ObterEntradaDisponibilidade(string mensagem)
    {
        Console.Write(mensagem);
        string entrada = Console.ReadLine();
        while (entrada != "1" && entrada != "0")
        {
            Console.WriteLine("Entrada inválida. Por favor, insira 1 para Disponível ou 0 para Indisponível.");
            Console.Write(mensagem);
            entrada = Console.ReadLine();
        }
        return entrada == "1";
    }

    public static void ExibirDadosAutomovel(Automovel auto)
    {
        Console.WriteLine($"Marca: {auto.Marca}, Modelo: {auto.Modelo}, Cor: {auto.Cor}, Matrícula: {auto.Matricula}, Ano: {auto.Ano}, Cilindrada: {auto.Cilindrada}, Preço de Aluguer: {auto.PrecoAluguer}, Disponibilidade: {(auto.Disponibilidade ? "Disponível" : "Indisponível")}");
    }
}
