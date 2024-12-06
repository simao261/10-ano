using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercicio5
{
    class Program
    {
        public struct Cliente
        {
            public string Nome;
            public int Nif;
            public string Cidade;

            public Cliente(string nome, int nif, string cidade)
            {
                Nome = nome;
                Nif = nif;
                Cidade = cidade;
            }
        }

        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[]
            {
                new Cliente("Ana Antunes", 123456789, "Coimbra"),
                new Cliente("Carlos Jorge", 987654321, "Viseu"),
                new Cliente("Maria Gomes", 432156789, "Lisboa")
            };

            try
            {
                using (StreamWriter ficheiro = new StreamWriter(@"clientes-empresa.txt"))
                {
                    for (int i = 0; i < clientes.Length; ++i)
                    {
                        ficheiro.WriteLine("Cliente nº{0} -> Nome: {1}, NIF: {2}, Cidade: {3}", i + 1, clientes[i].Nome, clientes[i].Nif, clientes[i].Cidade);
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
