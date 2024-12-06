using System;
using System.Collections.Generic;

public struct Aluno
{
    public string Nome { get; set; }
    public double Nota { get; set; }
}

class Program
{
    static List<Aluno> alunos = new List<Aluno>();

    static void Main()
    {
        Console.WriteLine("### Sistema de Registo de Classificações ###");

        // Inserir as notas dos alunos
        InserirNotas();

        // Mostrar resultados
        MostrarResultados();
    }

    static void InserirNotas()
    {
        while (true)
        {
            Console.Write("\nDigite o nome do aluno (ou 'fim' para terminar): ");
            string nome = Console.ReadLine();

            if (nome.ToLower() == "fim")
                break;

            Console.Write("Digite a nota do aluno: ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                Aluno novoAluno = new Aluno { Nome = nome, Nota = nota };
                alunos.Add(novoAluno);
            }
            else
            {
                Console.WriteLine("Nota inválida. Tente novamente.");
            }
        }
    }

    static void MostrarResultados()
    {
        if (alunos.Count == 0)
        {
            Console.WriteLine("\nNenhum aluno registado.");
            return;
        }

        Console.WriteLine("\n### Resultados ###");

        // 4.1. Alunos com nota >= 17
        List<Aluno> alunosNotaMaiorOuIgual17 = alunos.FindAll(a => a.Nota >= 17);
        if (alunosNotaMaiorOuIgual17.Count > 0)
        {
            Console.WriteLine("\nAlunos com nota igual ou superior a 17:");
            foreach (var aluno in alunosNotaMaiorOuIgual17)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
            }
        }
        else
        {
            Console.WriteLine("\nNenhum aluno obteve nota igual ou superior a 17.");
        }

        // 4.2. Alunos com nota < 7
        List<Aluno> alunosNotaInferior7 = alunos.FindAll(a => a.Nota < 7);
        Console.WriteLine($"\nNúmero de alunos com nota inferior a 7: {alunosNotaInferior7.Count}");

        // 4.3. Alunos abaixo da média
        double media = CalcularMedia();
        List<Aluno> alunosAbaixoMedia = alunos.FindAll(a => a.Nota < media);
        if (alunosAbaixoMedia.Count > 0)
        {
            Console.WriteLine("\nAlunos abaixo da média:");
            foreach (var aluno in alunosAbaixoMedia)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
            }
        }
        else
        {
            Console.WriteLine("\nTodos os alunos estão acima ou na média.");
        }

        // 4.4. Percentagem de alunos reprovados
        int alunosReprovados = alunos.Count - alunosAbaixoMedia.Count;
        double percentagemReprovados = (double)alunosReprovados / alunos.Count * 100;
        Console.WriteLine($"\nPercentagem de alunos reprovados: {percentagemReprovados:F2}%");
    }

    static double CalcularMedia()
    {
        double somaNotas = 0;
        foreach (var aluno in alunos)
        {
            somaNotas += aluno.Nota;
        }
        return alunos.Count > 0 ? somaNotas / alunos.Count : 0;
    }
}
