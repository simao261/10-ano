using System;
using System.Collections.Generic;

public struct EquipaFutebol
{
    public string Nome { get; set; }
    public int NumVitorias { get; set; }
    public int NumDerrotas { get; set; }
}

public struct Disciplina
{
    public string Nome { get; set; }
    public int Ano { get; set; }
    public double NotaFinal { get; set; }
}

class Program
{
    static void Main()
    {
        // Problema 2.1: Equipas de Futebol
        EquipaFutebol[] equipas = new EquipaFutebol[3]; // Supondo 3 equipas para exemplo

        Console.WriteLine("REGISTO DE EQUIPAS DE FUTEBOL\n");

        // Registo das equipas
        for (int i = 0; i < equipas.Length; i++)
        {
            Console.WriteLine($"Insira os dados da equipa {i + 1}:");
            EquipaFutebol equipa = LerEquipa();
            equipas[i] = equipa;
        }

        // Calcular e apresentar equipa com mais derrotas e mais vitórias
        string equipaComMaisDerrotas = ObterEquipaComMaisDerrotas(equipas);
        string equipaComMaisVitorias = ObterEquipaComMaisVitorias(equipas);

        Console.WriteLine("\nRESULTADOS PARA EQUIPAS DE FUTEBOL");
        Console.WriteLine($"Equipa com mais derrotas: {equipaComMaisDerrotas}");
        Console.WriteLine($"Equipa com mais vitórias: {equipaComMaisVitorias}\n");

        // Problema 2.2: Disciplinas de um Aluno
        Disciplina[] disciplinas = new Disciplina[3]; // Supondo 3 disciplinas para exemplo

        Console.WriteLine("REGISTO DE DISCIPLINAS DE UM ALUNO\n");

        // Registo das disciplinas
        for (int i = 0; i < disciplinas.Length; i++)
        {
            Console.WriteLine($"Insira os dados da disciplina {i + 1}:");
            Disciplina disciplina = LerDisciplina();
            disciplinas[i] = disciplina;
        }

        // Calcular e apresentar disciplinas com nota inferior a 10 e média final do aluno
        Console.WriteLine("\nRESULTADOS PARA DISCIPLINAS DE UM ALUNO");
        Console.WriteLine("Disciplinas com nota inferior a 10:");
        ListarDisciplinasComNotaInferiorA10(disciplinas);

        double mediaFinal = CalcularMediaFinal(disciplinas);
        Console.WriteLine($"\nMédia final do aluno: {mediaFinal}");
    }

    // Métodos para Equipas de Futebol

    static EquipaFutebol LerEquipa()
    {
        EquipaFutebol equipa = new EquipaFutebol();

        Console.Write("Nome da equipa: ");
        equipa.Nome = Console.ReadLine();

        Console.Write("Número de vitórias: ");
        equipa.NumVitorias = int.Parse(Console.ReadLine());

        Console.Write("Número de derrotas: ");
        equipa.NumDerrotas = int.Parse(Console.ReadLine());

        return equipa;
    }

    static string ObterEquipaComMaisDerrotas(EquipaFutebol[] equipas)
    {
        int maxDerrotas = equipas[0].NumDerrotas;
        string nomeEquipaMaxDerrotas = equipas[0].Nome;

        for (int i = 1; i < equipas.Length; i++)
        {
            if (equipas[i].NumDerrotas > maxDerrotas)
            {
                maxDerrotas = equipas[i].NumDerrotas;
                nomeEquipaMaxDerrotas = equipas[i].Nome;
            }
        }

        return nomeEquipaMaxDerrotas;
    }

    static string ObterEquipaComMaisVitorias(EquipaFutebol[] equipas)
    {
        int maxVitorias = equipas[0].NumVitorias;
        string nomeEquipaMaxVitorias = equipas[0].Nome;

        for (int i = 1; i < equipas.Length; i++)
        {
            if (equipas[i].NumVitorias > maxVitorias)
            {
                maxVitorias = equipas[i].NumVitorias;
                nomeEquipaMaxVitorias = equipas[i].Nome;
            }
        }

        return nomeEquipaMaxVitorias;
    }

    // Métodos para Disciplinas de um Aluno

    static Disciplina LerDisciplina()
    {
        Disciplina disciplina = new Disciplina();

        Console.Write("Nome da disciplina: ");
        disciplina.Nome = Console.ReadLine();

        Console.Write("Ano da disciplina: ");
        disciplina.Ano = int.Parse(Console.ReadLine());

        Console.Write("Nota final: ");
        disciplina.NotaFinal = double.Parse(Console.ReadLine());

        return disciplina;
    }

    static void ListarDisciplinasComNotaInferiorA10(Disciplina[] disciplinas)
    {
        foreach (Disciplina disciplina in disciplinas)
        {
            if (disciplina.NotaFinal < 10)
            {
                Console.WriteLine($"{disciplina.Nome} - Ano {disciplina.Ano}: Nota {disciplina.NotaFinal}");
            }
        }
    }

    static double CalcularMediaFinal(Disciplina[] disciplinas)
    {
        if (disciplinas.Length == 0)
        {
            return 0;
        }

        double somaNotas = 0;
        foreach (Disciplina disciplina in disciplinas)
        {
            somaNotas += disciplina.NotaFinal;
        }

        return somaNotas / disciplinas.Length;
    }
}
