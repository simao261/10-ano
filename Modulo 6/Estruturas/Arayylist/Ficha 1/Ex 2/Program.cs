using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList numeros = new ArrayList();
        InserirNumeros(numeros);
        PesquisarNumero(numeros);
    }

    static void InserirNumeros(ArrayList numeros)
    {
        Console.WriteLine("Insira alguns números inteiros (digite 'fim' para terminar):");

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
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido ou 'fim' para terminar.");
            }
        }
    }

    static void PesquisarNumero(ArrayList numeros)
    {
        Console.Write("Digite um número inteiro para pesquisar: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            if (numeros.Contains(x))
            {
                Console.WriteLine("ENCONTREI");
            }
            else
            {
                Console.WriteLine("NÃO ENCONTREI");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
        }
    }
}
