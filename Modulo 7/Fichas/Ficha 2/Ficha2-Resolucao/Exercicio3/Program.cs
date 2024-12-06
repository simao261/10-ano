using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = string.Empty;

            Console.Title = "";

            Console.WriteLine("A ler o ficheiro \"Edouard Manet.txt\"...");

            try
            {
                texto = File.ReadAllText(@"Edouard Manet.txt");
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao abrir/ler o ficheiro.");
            }

            Console.WriteLine("A substituir o caracter ' ' por '*'...");
            texto = texto.Replace(' ', '*');

            Console.WriteLine("A escrever o ficheiro \"Edouard Manet2.txt\"...");

            try
            {
                File.WriteAllText(@"Edouard Manet2.txt", texto);
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao criar/escrever no ficheiro.");
            }

            Console.WriteLine("\nOperação terminada");
            Console.ReadKey();
        }
    }
}
