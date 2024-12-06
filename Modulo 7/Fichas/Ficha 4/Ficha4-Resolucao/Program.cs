using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficha4_Resolucao
{
    internal class Program
    {
        public struct Automovel
        {
            public string Matricula;
            public int Ano;
            public int Quilometragem;
            public string Marca;
            public string Modelo;
            public decimal Preco;

            public Automovel(string matricula, int ano, int quilometragem, string marca, string modelo, decimal preco)
            {
                Matricula = matricula;
                Ano = ano; 
                Quilometragem = quilometragem;
                Marca = marca;
                Modelo = modelo;
                Preco = preco;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Ficha de Trabalho 4";

            #region "Escrever dados"
            /*Automovel automovel1 = new Automovel("10-AC-89", 2021, 25000, "Toyota", "Corolla Touring Sports", 23199.99M);

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(@"dados-automovel.dat", FileMode.Create)))
                {
                    writer.Write(automovel1.Matricula);
                    writer.Write(automovel1.Ano);
                    writer.Write(automovel1.Quilometragem);
                    writer.Write(automovel1.Marca);
                    writer.Write(automovel1.Modelo);
                    writer.Write(automovel1.Preco);
                }
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao tentar criar o ficheiro.");
            }*/
            #endregion

            #region "Ler dados"
            Automovel automovel2 = new Automovel();

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(@"dados-automovel.dat", FileMode.Open)))
                {
                    while (reader.PeekChar() >= 0)
                    {
                        automovel2.Matricula = reader.ReadString();
                        automovel2.Ano = reader.ReadInt32();
                        automovel2.Quilometragem = reader.ReadInt32();
                        automovel2.Marca = reader.ReadString();
                        automovel2.Modelo = reader.ReadString();
                        automovel2.Preco = reader.ReadDecimal();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao tentar utilizar o ficheiro.");
            }

            Console.WriteLine("Dados do automóvel:\n");
            Console.WriteLine("Matrícula: {0}", automovel2.Matricula);
            Console.WriteLine("Ano: {0}", automovel2.Ano);
            Console.WriteLine("Quilometragem: {0}", automovel2.Quilometragem);
            Console.WriteLine("Marca: {0}", automovel2.Marca);
            Console.WriteLine("Modelo: {0}", automovel2.Modelo);
            Console.WriteLine("Preço: {0} €", automovel2.Preco);

            Console.ReadKey();
            #endregion
        }
    }
}
