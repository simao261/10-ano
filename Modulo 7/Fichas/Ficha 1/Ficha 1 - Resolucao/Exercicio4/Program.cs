using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = { 10.1, -9, 12.9, 22, 15.1, -4.5, 11, 10, -7.5, 30 };

            try
            {
                using (StreamWriter ficheiro = new StreamWriter(@"temperaturas.txt"))
                {
                    for (int i = 0; i < temperaturas.Length; ++i)
                    {
                        ficheiro.WriteLine("Temperatura no dia {0}: {1} graus", i, temperaturas[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao criar/escrever no ficheiro.");
            }
        }
    }
}
