using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_de_Revisão_Para_o_Teste
{
    internal class Program
    {
        public static double maiorPeso = 0, menorPeso = 0;
        public static string menornome, maiornome;
        static void Main(string[] args)
        {
          // 1

          for ( int i = 0; i < 5; i++ )
          {
                Console.WriteLine($"Insira o nome do aluno: {i + 1 } ");
                string nomedoaluno = Console.ReadLine();
                Console.WriteLine($"insira o Peso do aluno: {i + 1}");
                double Pesoaluno = int.Parse( Console.ReadLine() );

                if ( i == 0 )
                {
                    maiorPeso = Pesoaluno;
                    maiornome = nomedoaluno;
                    menorPeso = Pesoaluno;
                    menornome = nomedoaluno;

                }
                else
                {
                    maior(Pesoaluno, nomedoaluno);
                    menor(Pesoaluno, nomedoaluno);
                }

             
          }

            Console.WriteLine("\nO aluno: " + maiornome + " e o mais Pesado!");
            Console.WriteLine("\nO aluno: " + menornome + " è o menos Pesado!");
            Console.WriteLine();


            // ex 2

          

            Console.WriteLine("introduza o numero de linhas: ");
            int linhas = int.Parse( Console.ReadLine() );
            Console.WriteLine("Qual o simbolo pretendido: ");
            char simbolo = char.Parse( Console.ReadLine() );
            escrever (simbolo, linhas );

            Console.ReadKey();

        }

        // 1 
        static void maior ( double peso , string nome )
        {
            if ( peso > maiorPeso )
            {
                maiorPeso = peso;
                maiornome = nome;
            }
        }
        static void menor ( double peso , string nome )
        {
            if ( peso < menorPeso )
            {
                menorPeso = peso;
                menornome = nome;
            }
        }

        // 2 

        static void escrever ( char simbolo , int linhas )
        {
            for ( int j = 1 ; j <= linhas ; j++ )
            {
                for ( int i = 1 ; i <= linhas ; i++ )
                {
                    Console.Write(simbolo );

                }
                Console.WriteLine("");
            }
        }

    }
}
