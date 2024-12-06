using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_simaão_Rodrigues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Insira o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int Resultado = Somadosvalores ( valor1, valor2);

            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é {Resultado}");

            // 2

            string Nomemaisleve = "";
            string nomemaisPesado = "";
         
            for ( int i = 1; i <= 5; i++)
            {
               

                Console.WriteLine("Insira o nome do aluno: " + i);
                string Nome = Console.ReadLine();
                Console.WriteLine("Insira o Peso do aluno: " + i);
                double Peso = double.Parse(Console.ReadLine());

              



            }

           Console.WriteLine("o aluno mais leve é: " + Nomemaisleve );
           Console.WriteLine("o aluno mais pesado é: " + nomemaisPesado );


            Console.ReadKey();

        }

        // 1
        static int Somadosvalores ( int valor1, int valor2)
        {
            int SOMA = 0;
            if ( valor1 < 0 || valor2 < 0) 
            {
                int Valor1Positivo = Math.Abs(valor1);
                int valor2Positivo = Math.Abs(valor2);

                Console.WriteLine($"Os valores {valor1} e {valor2} Passaram a {Valor1Positivo} e {valor2Positivo}");
                
            }
            if (valor1 + valor2 > 100 )
            {
                Console.WriteLine("Ultrapassou o Limite");
            }
            else
            {
                return valor2 + valor1;
            }
            return SOMA;
            

        }

        // 2

        static double maisleve (string Nomemaisleve,string nome, double maisleve, double peso)
        {
            
            if (peso < maisleve )
            {
                maisleve = peso;
                Nomemaisleve = nome;




            }
            return maisleve;
            
        }

        static double maispesado(string nomemaisPesado, string nome, double maispesado , double peso )
        {
            if ( peso > maispesado )
            {
               maispesado = peso;
                nomemaisPesado = nome;

            }
            return maispesado;
        }







    }
}
