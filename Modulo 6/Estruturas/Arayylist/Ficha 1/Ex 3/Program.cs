using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList vetor1 = new ArrayList();
        ArrayList vetor2 = new ArrayList();

        Console.WriteLine("Inserir números no primeiro vetor:");
        InserirNumeros(vetor1);

        Console.WriteLine("Inserir números no segundo vetor:");
        InserirNumeros(vetor2);

        Console.WriteLine("\nSoma de todos os elementos dos dois vetores:");
        int somaTotal = SomarElementos(vetor1) + SomarElementos(vetor2);
        Console.WriteLine($"Soma total: {somaTotal}");

        Console.WriteLine("\nSoma dos vetores (índice por índice):");
        ArrayList vetorSoma = SomarVetores(vetor1, vetor2);
        ExibirVetor(vetorSoma, "Vetor Soma");
    }

    static void InserirNumeros(ArrayList vetor)
    {
        Console.WriteLine("Insira números inteiros (digite 'fim' para terminar):");

        while (true)
        {
            Console.Write("Número: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "fim")
            {
                break;
            }

            if (int.TryParse(input, out int numero))
            {
                vetor.Add(numero);
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido ou 'fim' para terminar.");
            }
        }
    }

    static int SomarElementos(ArrayList vetor)
    {
        int soma = 0;
        foreach (int numero in vetor)
        {
            soma += numero;
        }
        return soma;
    }

    static ArrayList SomarVetores(ArrayList vetor1, ArrayList vetor2)
    {
        ArrayList vetorSoma = new ArrayList();
        int tamanhoMax = Math.Max(vetor1.Count, vetor2.Count);

        for (int i = 0; i < tamanhoMax; i++)
        {
            int soma = 0;

            if (i < vetor1.Count)
            {
                soma += (int)vetor1[i];
            }

            if (i < vetor2.Count)
            {
                soma += (int)vetor2[i];
            }

            vetorSoma.Add(soma);
        }

        return vetorSoma;
    }

    static void ExibirVetor(ArrayList vetor, string nomeVetor)
    {
        Console.WriteLine($"{nomeVetor}:");
        foreach (int numero in vetor)
        {
            Console.WriteLine(numero);
        }
    }
}
