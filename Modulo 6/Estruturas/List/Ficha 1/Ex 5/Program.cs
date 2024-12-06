using System;
using System.Collections.Generic;

public struct livro
{
    public string titulo;
    public string autor;
    public int n_exemplares;
    public double preco;
    public string ano;
}

class Program
{
    static List<livro> livraria = new List<livro>();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n### Gestão de Livraria ###");
            Console.WriteLine("1. Inserir novo livro");
            Console.WriteLine("2. Pesquisar livros por autor");
            Console.WriteLine("3. Pesquisar preço de um livro");
            Console.WriteLine("4. Pesquisar número de exemplares de um livro");
            Console.WriteLine("5. Calcular valor total dos livros");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        InserirLivro();
                        break;
                    case 2:
                        PesquisarLivrosPorAutor();
                        break;
                    case 3:
                        PesquisarPrecoLivro();
                        break;
                    case 4:
                        PesquisarExemplaresLivro();
                        break;
                    case 5:
                        CalcularValorTotal();
                        break;
                    case 6:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

        } while (opcao != 6);
    }

    static void InserirLivro()
    {
        livro novoLivro = new livro();

        Console.Write("Digite o título do livro: ");
        novoLivro.titulo = Console.ReadLine();

        Console.Write("Digite o nome do autor: ");
        novoLivro.autor = Console.ReadLine();

        Console.Write("Digite o número de exemplares: ");
        if (int.TryParse(Console.ReadLine(), out int exemplares))
        {
            novoLivro.n_exemplares = exemplares;
        }
        else
        {
            Console.WriteLine("Número inválido. Inserção cancelada.");
            return;
        }

        Console.Write("Digite o preço unitário: ");
        if (double.TryParse(Console.ReadLine(), out double preco))
        {
            novoLivro.preco = preco;
        }
        else
        {
            Console.WriteLine("Preço inválido. Inserção cancelada.");
            return;
        }

        Console.Write("Digite o ano de publicação: ");
        novoLivro.ano = Console.ReadLine();

        livraria.Add(novoLivro);
        Console.WriteLine("Livro inserido com sucesso.");
    }

    static void PesquisarLivrosPorAutor()
    {
        Console.Write("Digite o nome do autor para pesquisar: ");
        string autor = Console.ReadLine();

        List<string> titulos = new List<string>();

        foreach (var livro in livraria)
        {
            if (livro.autor.Equals(autor, StringComparison.OrdinalIgnoreCase))
            {
                titulos.Add(livro.titulo);
            }
        }

        if (titulos.Count > 0)
        {
            Console.WriteLine($"Livros escritos por {autor}:");
            foreach (var titulo in titulos)
            {
                Console.WriteLine(titulo);
            }
        }
        else
        {
            Console.WriteLine($"Não foram encontrados livros escritos por {autor}.");
        }
    }

    static void PesquisarPrecoLivro()
    {
        Console.Write("Digite o título do livro para pesquisar o preço: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        foreach (var livro in livraria)
        {
            if (livro.titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Preço do livro '{livro.titulo}': {livro.preco:F2} euros");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"Livro '{titulo}' não encontrado na livraria.");
        }
    }

    static void PesquisarExemplaresLivro()
    {
        Console.Write("Digite o título do livro para pesquisar o número de exemplares: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        foreach (var livro in livraria)
        {
            if (livro.titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Número de exemplares do livro '{livro.titulo}': {livro.n_exemplares}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"Livro '{titulo}' não encontrado na livraria.");
        }
    }

    static void CalcularValorTotal()
    {
        double valorTotal = 0;

        foreach (var livro in livraria)
        {
            valorTotal += livro.n_exemplares * livro.preco;
        }

        Console.WriteLine($"Valor total dos livros na livraria: {valorTotal:F2} euros");
    }
}
