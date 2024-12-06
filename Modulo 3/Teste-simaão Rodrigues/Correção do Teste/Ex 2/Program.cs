using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        public static double maior_peso = 0, menor_peso = 0;
        public static string maior_nome, menor_nome;
        public static void Main(string[] args)
        {
            double peso;
            string nome;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira o peso (kg) do aluno nº" + (i + 1));
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o nome do aluno nº" + (i + 1));
                nome = Console.ReadLine();

                if (i == 0)
                {
                    maior_peso = peso;
                    maior_nome = nome;
                    menor_peso = peso;
                    menor_nome = nome;
                }
                else
                {
                    maior(peso, nome);
                    menor(peso, nome);
                }
            }

            Console.WriteLine("\nO aluno " + (maior_nome) + " é o mais pesado com " + (maior_peso) + " kg");
            Console.WriteLine("\nO aluno " + (menor_nome) + " é o mais leve com " + (menor_peso) + " kg");
            
            Console.ReadKey(true);
        }
        public static void maior(double p, string n)
        {
            if (p > maior_peso)
            {
                maior_peso = p;
                maior_nome = n;
            }
        }
        public static void menor(double p, string n)
        {
            if (p < menor_peso)
            {
                menor_peso = p;
                menor_nome = n;
            }
        }
       


    }
}

