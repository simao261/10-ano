using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o Primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int menor = Math.Min(numero1, numero2);
            int maior = Math.Max(numero1, numero2);

            int Resultado = CalcularsomadosPares (menor, maior);

            Console.WriteLine($"A soma dos Pares entre {numero1} e {numero2} é: {Resultado} ");
            Console.ReadKey();

        }

        static int CalcularsomadosPares( int menor , int maior )
        {
            int soma = 0;
            for ( int i = menor; i <= maior; i++)
            {
                if ( i % 2== 0 )
                {
                    soma += i;
                }
            }
            return soma;
        }
    }
}
