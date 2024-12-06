using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestor_SMS
{
    class Program
    {
        // Escrever código aqui: definir struct Sms

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Gestor de SMS";

            // Escrever código aqui: declarar lista de sms

            // Escrever código aqui: inserir 4 sms na lista

            string comando;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Gestor de SMS\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Comandos disponíveis:");
                Console.WriteLine("1: Mostrar lista de sms");
                Console.WriteLine("2: Apagar sms");
                Console.WriteLine("3: Sair");

                Console.Write("\n> ");
                comando = Console.ReadLine();

                switch (comando)
                {
                    case "1":
                        int n = 0;

                        Console.WriteLine();

                        // Escrever código aqui: percorrer lista de sms e mostrar os dados de cada mensagem

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("(pressione qualquer tecla para voltar ao menu)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;

                    case "2":
                        int numeroSms;

                        Console.Write("Número do sms a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out numeroSms) == true)
                        {
                            // Escrever código aqui: remover sms da lista
                            // (o índice do sms a remover está na variável numeroSms)
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("(pressione qualquer tecla para voltar ao menu)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;
                }

                Console.Clear();

            } while (1 == 1);
        }
    }
}
