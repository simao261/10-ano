using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercicio3
{
    class Program
    {
        public struct Jogador
        {
            public string Nome;
            public int Pontuacao;
            public int Vidas;
            public int Nivel;

            public Jogador(string nome, int pontuacao, int vidas, int nivel)
            {
                Nome = nome;
                Pontuacao = pontuacao;
                Vidas = vidas;
                Nivel = nivel;
            }
        }

        static void Main(string[] args)
        {
            Jogador dadosJogador = new Jogador("Jonas José", 1200, 2, 5);

            try
            {
                using (StreamWriter ficheiro = new StreamWriter(@"save-jogador.ini"))
                {
                    ficheiro.WriteLine("nome={0}", dadosJogador.Nome);
                    ficheiro.WriteLine("pontuacao={0}", dadosJogador.Pontuacao);
                    ficheiro.WriteLine("vidas={0}", dadosJogador.Vidas);
                    ficheiro.WriteLine("nivel={0}", dadosJogador.Nivel);
                }
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro ao criar/escrever no ficheiro.");
            }
        }
    }
}
