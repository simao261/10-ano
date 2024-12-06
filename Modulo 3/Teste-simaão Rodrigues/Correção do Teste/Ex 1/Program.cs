using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_do_Teste
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

            int Resultado = Somadosvalores(valor1, valor2);

            Console.WriteLine($"A soma dos valores {valor1} e {valor2} é {Resultado}");
            Console.ReadKey();

           


        }

        // 1 
        static int Somadosvalores(int valor1, int valor2)
        {
            int SOMA = 0;
            if (valor1 < 0 || valor2 < 0)
            {
                int Valor1Positivo = Math.Abs(valor1);
                int valor2Positivo = Math.Abs(valor2);

                Console.WriteLine($"Os valores {valor1} e {valor2} Passaram a {Valor1Positivo} e {valor2Positivo}");

            }
            if (valor1 + valor2 > 100)
            {
                
                Console.WriteLine("Ultrapassou o Limite");
                return 0;

            }
            else
            {
                return (valor1 + valor2);
                
            }
           
            


        }


        

        







    }
}
