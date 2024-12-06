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
            string titulo = "Os Maias";
            string autor = "Eça de Queirós";
            DateTime data = new DateTime(2020, 09, 01);

            try
            {
                using (StreamWriter ficheiro = new StreamWriter(@"encomenda-livro.txt"))
                {
                    ficheiro.WriteLine("Obrigado por ter efetuado a encomenda do livro \"{0}\" de \"{1}\"", titulo, autor);
                    ficheiro.WriteLine("Data de entrega prevista: {0}", data.ToString("dd/MM/yyyy"));
                }
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao criar/escrever no ficheiro.");
            }
        }
    }
}
