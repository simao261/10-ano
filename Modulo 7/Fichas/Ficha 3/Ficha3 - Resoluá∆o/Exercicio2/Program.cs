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
            string linha;
            int i = 1;

            Console.Title = "";

            try
            {
                using (StreamReader ficheiro = new StreamReader(@"ascii-art.txt"))
                {
                    while ((linha = ficheiro.ReadLine()) != null)
                    {
                        Console.WriteLine("Linha {0} -> {1}", i++, linha);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao abrir/ler o ficheiro.");
            }

            Console.ReadKey();
        }
    }
}
