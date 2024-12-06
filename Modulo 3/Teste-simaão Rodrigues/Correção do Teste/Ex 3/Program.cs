using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 1, j = 1;

            Console.WriteLine("Introduza o número de linhas: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o simbolo pretendido? ");
            char simbolo = char.Parse(Console.ReadLine());
            escrever(simbolo, linhas);
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        public static void escrever(char c, int num)
        {

            for (int j = 1; j <= num; j++)
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.Write(c);

                }
                Console.WriteLine("");
            }
        }
    }
}
    
