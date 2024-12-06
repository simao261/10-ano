using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercício 1: Variáveis e Operadores");

        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int soma = num1 + num2;
        int subtracao = num1 - num2;
        int multiplicacao = num1 * num2;

        
        int divisao = 0;
        try
        {
            divisao = num1 / num2;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Divisão por zero.");
        }

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        
        if (divisao != 0)
        {
            Console.WriteLine($"Divisão: {divisao}");
        }
    }
}
