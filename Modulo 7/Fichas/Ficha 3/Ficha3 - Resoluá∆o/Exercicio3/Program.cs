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
            string linha, nome;
            int linhaConsola = 0;
            int indice;
            int votos;

            Console.Title = "";

            try
            {
                using (StreamReader ficheiro = new StreamReader(@"votacao.txt"))
                {
                    while ((linha = ficheiro.ReadLine()) != null)
                    {
                        indice = linha.IndexOf('=');
                        nome = linha.Substring(0, indice);
                        votos = int.Parse(linha.Substring(indice + 1));

                        Console.Write("{0}: ", nome);

                        Console.SetCursorPosition(12, linhaConsola);
                        for (int i = 1; i <= votos; ++i)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                        linhaConsola++;
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
