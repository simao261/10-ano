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
            string texto = "Princípios fundamentais" + Environment.NewLine + Environment.NewLine;
            texto += "Artigo 1.º" + Environment.NewLine + Environment.NewLine;
            texto += "República Portuguesa" + Environment.NewLine + Environment.NewLine;
            texto += "Portugal é uma República soberana, baseada na dignidade da pessoa humana e na vontade popular e empenhada na construção de uma sociedade livre, justa e solidária." + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            texto += "Artigo 2.º" + Environment.NewLine + Environment.NewLine;
            texto += "Estado de direito democrático" + Environment.NewLine + Environment.NewLine;
            texto += "A República Portuguesa é um Estado de direito democrático, baseado na soberania popular, no pluralismo de expressão e organização política democráticas, no respeito e na garantia de efetivação dos direitos e liberdades fundamentais e na separação e interdependência de poderes, visando a realização da democracia económica, social e cultural e o aprofundamento da democracia participativa.";

            try
            {
                File.WriteAllText(@"ConstituiçãoPortuguesa.txt", texto);
            }
            catch 
            {
                Console.WriteLine("Ocorreu um erro ao criar/escrever no ficheiro.");
            }

            Console.ReadKey();
        }
    }
}
