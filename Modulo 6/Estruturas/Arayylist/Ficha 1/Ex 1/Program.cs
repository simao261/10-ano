using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList vetor = new ArrayList();
        Menu(vetor);
    }

    static void InserirNome(ArrayList vetor, string nome)
    {
        vetor.Add(nome);
        Console.WriteLine($"Nome '{nome}' inserido com sucesso.");
    }

    static void RemoverNome(ArrayList vetor, string nome)
    {
        if (vetor.Contains(nome))
        {
            vetor.Remove(nome);
            Console.WriteLine($"Nome '{nome}' removido com sucesso.");
        }
        else
        {
            Console.WriteLine($"Nome '{nome}' não encontrado no vetor.");
        }
    }

    static void EscreverConteudo(ArrayList vetor)
    {
        if (vetor.Count > 0)
        {
            Console.WriteLine("Conteúdo do vetor:");
            for (int i = 0; i < vetor.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vetor[i]}");
            }
        }
        else
        {
            Console.WriteLine("O vetor está vazio.");
        }
    }

    static void Menu(ArrayList vetor)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Inserir nome");
            Console.WriteLine("2. Remover nome");
            Console.WriteLine("3. Escrever conteúdo");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite o nome a ser inserido: ");
                    string nomeInserir = Console.ReadLine();
                    InserirNome(vetor, nomeInserir);
                    break;

                case "2":
                    Console.Write("Digite o nome a ser removido: ");
                    string nomeRemover = Console.ReadLine();
                    RemoverNome(vetor, nomeRemover);
                    break;

                case "3":
                    EscreverConteudo(vetor);
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
