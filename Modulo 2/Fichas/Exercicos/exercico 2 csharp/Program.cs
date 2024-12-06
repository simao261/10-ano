using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercício 2: Estruturas de Controle de Fluxo");

        Console.Write("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Número Par");
        }
        else
        {
            Console.WriteLine("Número Ímpar");
        }
    }
}
