using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        }
    }
}
