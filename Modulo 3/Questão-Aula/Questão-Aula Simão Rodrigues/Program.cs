using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão_Aula_Simão_Rodrigues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos valores deseja inserir?");
            double quantidade = double.Parse(Console.ReadLine());

            double[] valores = new double[(int)quantidade];

           
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Insira o {i + 1}º valor: ");
                valores[i] = double.Parse(Console.ReadLine());
            }

            
            Console.WriteLine($"Maior valor inserido: {Maior(valores)}");
            Console.WriteLine($"Menor valor inserido: {Menor(valores)}");
            Console.WriteLine($"Soma dos valores inseridos: {Soma(valores)}");
            Console.WriteLine($"Média dos valores inseridos: {Media(valores)}");
            Console.ReadKey();
        }

        static double Maior(double[] valores)
        {
            double maior = valores[0];
            foreach (double valor in valores)
            {
                if (valor > maior)
                {
                    maior = valor;
                }
            }
            return maior;
        }

        static double Menor(double[] valores)
        {
            double menor = valores[0];
            foreach (double valor in valores)
            {
                if (valor < menor)
                {
                    menor = valor;
                }
            }
            return menor;
        }

        static double Soma(double[] valores)
        {
            double soma = 0;
            foreach (double valor in valores)
            {
                soma += valor;
            }
            return soma;
        }

        static double Media(double[] valores)
        {
            return (double)Soma(valores) / valores.Length;
        }


    }
}
