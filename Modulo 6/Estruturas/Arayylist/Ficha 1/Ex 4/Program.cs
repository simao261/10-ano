using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList classificacoes = new ArrayList();
        InserirClassificacoes(classificacoes);

        int alunoMax = ObterAlunoComClassificacaoMaxima(classificacoes);
        int alunoMin = ObterAlunoComClassificacaoMinima(classificacoes);
        int alunosAbaixoMedia = ContarAlunosAbaixoMedia(classificacoes);
        int alunosAcimaMedia = ContarAlunosAcimaMedia(classificacoes);

        Console.WriteLine($"\nNúmero do aluno com a classificação mais elevada: {alunoMax + 1}");
        Console.WriteLine($"Número do aluno com a classificação menos elevada: {alunoMin + 1}");
        Console.WriteLine($"Número de alunos com classificações inferiores à média: {alunosAbaixoMedia}");
        Console.WriteLine($"Número de alunos com classificações superiores ou iguais à média: {alunosAcimaMedia}");
    }

    static void InserirClassificacoes(ArrayList classificacoes)
    {
        Console.WriteLine("Insira as classificações dos alunos (valores reais, digite 'fim' para terminar):");

        while (true)
        {
            Console.Write("Classificação: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "fim")
            {
                break;
            }

            if (double.TryParse(input, out double classificacao))
            {
                classificacoes.Add(classificacao);
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor real válido ou 'fim' para terminar.");
            }
        }
    }

    static int ObterAlunoComClassificacaoMaxima(ArrayList classificacoes)
    {
        int indiceMax = 0;
        double max = (double)classificacoes[0];

        for (int i = 1; i < classificacoes.Count; i++)
        {
            if ((double)classificacoes[i] > max)
            {
                max = (double)classificacoes[i];
                indiceMax = i;
            }
        }

        return indiceMax;
    }

    static int ObterAlunoComClassificacaoMinima(ArrayList classificacoes)
    {
        int indiceMin = 0;
        double min = (double)classificacoes[0];

        for (int i = 1; i < classificacoes.Count; i++)
        {
            if ((double)classificacoes[i] < min)
            {
                min = (double)classificacoes[i];
                indiceMin = i;
            }
        }

        return indiceMin;
    }

    static int ContarAlunosAbaixoMedia(ArrayList classificacoes)
    {
        double media = CalcularMedia(classificacoes);
        int contador = 0;

        foreach (double classificacao in classificacoes)
        {
            if (classificacao < media)
            {
                contador++;
            }
        }

        return contador;
    }

    static int ContarAlunosAcimaMedia(ArrayList classificacoes)
    {
        double media = CalcularMedia(classificacoes);
        int contador = 0;

        foreach (double classificacao in classificacoes)
        {
            if (classificacao >= media)
            {
                contador++;
            }
        }

        return contador;
    }

    static double CalcularMedia(ArrayList classificacoes)
    {
        double soma = 0;

        foreach (double classificacao in classificacoes)
        {
            soma += (double)classificacao;
        }

        return soma / classificacoes.Count;
    }
}
