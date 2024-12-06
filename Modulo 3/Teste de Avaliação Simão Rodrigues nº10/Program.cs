using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Avaliação_Simão_Rodrigues_nº10
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            /*Console.WriteLine("Insira um numero: ");
            int Numero = int.Parse(Console.ReadLine());*/



            // 2 


            for (int i = 1; i > 0; i++)
            {

                Console.WriteLine($"Insira a idade da {i + 1} Pessoa: ");
                double idades = int.Parse(Console.ReadLine());

                double maior = Math.Max(idades);
                double menor = Math.Min(idades);


                if ( idades == 0)
                {
                    Console.ReadKey();
                }
                Console.ReadKey();

            }
          
             

          // 3

          Console.WriteLine("insira um valor: ");
          int valor = int.Parse(Console.ReadLine());

          int Resultado = Somadosnumeros (valor);

          Console.WriteLine($" A soma de todos os numeros do valor {valor} é: {Somadosnumeros(valor)}");
            Console.ReadKey();

        }

        static void numerospares ( int numero , int maior , int menor )
        {
            int soma = 0;
            for (int i = 1; i < menor; i <= maior, i++)
            {
                if ( i % 2 == 0 )
                {
                    soma += i;
                }
            }
            
        }
         

        // 2 

       static int mediaidades ( double media , int idades , int Media  )
        {

            double Mediua = 0;

            for ( int i = 0; idades > 0; i++)
            {
                Media = (int)((double)media / idades);
            }
            return Media;
            
           


       }

        // 3 

        static int Somadosnumeros(int valor)
        {
            int soma = 0;
            if (valor > 1 && valor < 1000)
            {
                 return 1;

            }
           
            for ( int i = 0; i < valor; i++ )
            {
                soma++;
                return soma;
            }
            return soma;
            
           
        }

        

        
        
         





    }
}
