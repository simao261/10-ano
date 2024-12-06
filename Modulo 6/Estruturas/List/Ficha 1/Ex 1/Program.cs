using System;
using System.Collections.Generic;

class Program
{
    public struct Aluno
    {
        public string Nome { get; set; }
        public double Classificacao { get; set; }
    }

    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();

        // Registro das classificações dos alunos
        RegistrarClassificacoes(alunos);

        // 1.1. Nome dos alunos com nota superior a 13
        List<string> alunosAcimaDe13 = ObterAlunosAcimaDe13(alunos);
        Console.WriteLine("\nAlunos com nota superior a 13:");
        foreach (string nome in alunosAcimaDe13)
        {
            Console.WriteLine(nome);
        }

        // 1.2. Quantidade de alunos com nota inferior a 10 e seus nomes
        List<Aluno> alunosAbaixoDe10 = ObterAlunosAbaixoDe10(alunos);
        Console.WriteLine($"\nNúmero de alunos com nota inferior a 10: {alunosAbaixoDe10.Count}");
        Console.WriteLine("Alunos com nota inferior a 10:");
        foreach (Aluno aluno in alunosAbaixoDe10)
        {
            Console.WriteLine($"{aluno.Nome}: {aluno.Classificacao}");
        }

        // 1.3. Percentagem de alunos aprovados
        double percentagemAprovados = CalcularPercentagemAprovados(alunos);
        Console.WriteLine($"\nPercentagem de alunos aprovados: {percentagemAprovados}%");
    }

    static void RegistrarClassificacoes(List<Aluno> alunos)
    {
        Console.WriteLine("Registo das classificações dos alunos (digite 'fim' para terminar):");

        while (true)
        {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            if (nome.ToLower() == "fim")
            {
                break;
            }

            Console.Write("Classificação: ");
            if (double.TryParse(Console.ReadLine(), out double classificacao))
            {
                alunos.Add(new Aluno { Nome = nome, Classificacao = classificacao });
            }
            else
            {
                Console.WriteLine("Por favor, insira uma classificação válida.");
            }
        }
    }

    static List<string> ObterAlunosAcimaDe13(List<Aluno> alunos)
    {
        List<string> alunosAcimaDe13 = new List<string>();

        foreach (Aluno aluno in alunos)
        {
            if (aluno.Classificacao > 13)
            {
                alunosAcimaDe13.Add(aluno.Nome);
            }
        }

        return alunosAcimaDe13;
    }

    static List<Aluno> ObterAlunosAbaixoDe10(List<Aluno> alunos)
    {
        List<Aluno> alunosAbaixoDe10 = new List<Aluno>();

        foreach (Aluno aluno in alunos)
        {
            if (aluno.Classificacao < 10)
            {
                alunosAbaixoDe10.Add(aluno);
            }
        }

        return alunosAbaixoDe10;
    }

    static double CalcularPercentagemAprovados(List<Aluno> alunos)
    {
        int aprovados = 0;
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Classificacao >= 10)
            {
                aprovados++;
            }
        }

        return (double)aprovados / alunos.Count * 100;
    }
}
