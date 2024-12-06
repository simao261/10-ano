using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ficheiro;
            string conteudoFicheiro = string.Empty;

            Console.Title = "";

            Console.WriteLine("Insira a path (localização) e nome de um ficheiro de texto:");
            ficheiro = Console.ReadLine();

            if (ficheiro != String.Empty)
            {
                try
                {
                    conteudoFicheiro = File.ReadAllText(@ficheiro);
                }
                catch
                {
                    Console.WriteLine("Ocorreu um erro ao abrir/ler o ficheiro.");
                }

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Conteúdo do ficheiro {0}:\n", ficheiro);

                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = 0; i < conteudoFicheiro.Length && !Console.KeyAvailable; ++i)
                {
                    Console.Write(conteudoFicheiro[i]);
                    System.Threading.Thread.Sleep(20);
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n[Fim do ficheiro]");
                Console.ReadKey();
            }
        }
    }
}
