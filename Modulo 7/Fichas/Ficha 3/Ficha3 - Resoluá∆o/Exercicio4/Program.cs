using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection.Emit;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha;
            string mes = string.Empty;
            int dia = 0;
            int totalMes = 0;

            Console.Title = "";

            try
            {
                using (StreamReader ficheiro = new StreamReader(@"bilhetes-vendidos.txt"))
                {
                    while ((linha = ficheiro.ReadLine()) != null)
                    {
                        if (int.TryParse(linha, out dia))
                        {
                            totalMes += dia;
                        }
                        else
                        {
                            if (linha == "-")
                            {
                                Console.WriteLine("Total do mês de {0}: {1} bilhetes vendidos", mes, totalMes);
                                mes = string.Empty;
                                totalMes = 0;
                            }
                            else
                            {
                                mes = linha;
                            }
                        }
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
