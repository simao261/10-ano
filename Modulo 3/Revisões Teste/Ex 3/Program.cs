using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int escolha;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1- Soma");
                Console.WriteLine("2- Pares");
                Console.WriteLine("3- Maior");
                Console.WriteLine("4- Altura do dia");
                Console.WriteLine("5- Conversão entre diferentes unidades de medida");
                Console.WriteLine("0- Sair");
                Console.Write("Escolha uma opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Soma010();
                        break;
                    case 2:
                        SomaPares0100();
                        break;
                    case 3:
                        Maior();
                        break;
                    case 4:
                        Alturadodia();
                        break;
                    case 0;
                        Console.WriteLine("A sair...");
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;

                }





            } while (escolha != 0);


        }

        static void Soma010()
        {
            int soma = 0, i = 0;
            while (i <= 10)

            {
                soma += i;
                i++;
            }

            Console.WriteLine("A soma dos números entre 0 e 10 é: " + soma);

        }

        static void SomaPares0100()
        {
            int soma = 0;
            for (int i = 0; i <= 100; i = 2)
            {
                soma += i;

            }

            Console.WriteLine("A soma dos números pares entre 0 e 100 é: " + soma);

        }

        static void Maior()
        {
            int maior = -1, numero;

            do
            {
                Console.Write("Digite um número inteiro positivo (ou 0 para terminar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }
            } while (numero != 0);

            Console.WriteLine("O maior número digitado foi: " + maior);
        }

    }
}
        


    