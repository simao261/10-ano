using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = string.Empty;

            Console.Title = "";
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                texto = File.ReadAllText(@"ConstituiçãoPortuguesa.txt");
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao abrir/ler o ficheiro.");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CONSTITUIÇÃO DA REPÚBLICA PORTUGUESA\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(texto);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------------");

            Console.ReadKey();
        }
    }
}
