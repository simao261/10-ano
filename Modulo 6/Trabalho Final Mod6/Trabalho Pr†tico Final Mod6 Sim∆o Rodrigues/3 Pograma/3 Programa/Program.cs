using System;
using System.Collections.Generic;

namespace _3_Programa
{
    public struct Aviao
    {
        public string Nome;
        public int Identificador;
        public string Modelo;
        public int Capacidade;

        public Aviao(string nome, int identificador, string modelo, int capacidade)
        {
            Nome = nome;
            Identificador = identificador;
            Modelo = modelo;
            Capacidade = capacidade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Identificador: {Identificador}, Modelo: {Modelo}, Capacidade: {Capacidade}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<Aviao> filaDescolagem = new Queue<Aviao>();

            while (true)
            {
                Console.WriteLine("Sistema de Controlo de Pista de Descolagem");
                Console.WriteLine("1. Listar o número de aviões que aguardam na fila de descolagem");
                Console.WriteLine("2. Autorizar a descolagem do primeiro avião da fila");
                Console.WriteLine("3. Adicionar um avião à fila de espera");
                Console.WriteLine("4. Listar todos os aviões na fila de espera");
                Console.WriteLine("5. Listar as características do primeiro avião da fila");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine($"Número de aviões na fila de descolagem: {filaDescolagem.Count}");
                        break;

                    case "2":
                        if (filaDescolagem.Count > 0)
                        {
                            Aviao aviaoDescolar = filaDescolagem.Dequeue();
                            Console.WriteLine($"Autorizada a descolagem do avião: {aviaoDescolar}");
                        }
                        else
                        {
                            Console.WriteLine("Não há aviões na fila de descolagem.");
                        }
                        break;

                    case "3":
                        Console.Write("Nome do avião: ");
                        string nome = Console.ReadLine();
                        Console.Write("Identificador do avião: ");
                        int identificador;
                        while (!int.TryParse(Console.ReadLine(), out identificador))
                        {
                            Console.Write("Identificador inválido. Digite novamente: ");
                        }
                        Console.Write("Modelo do avião: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Capacidade do avião: ");
                        int capacidade;
                        while (!int.TryParse(Console.ReadLine(), out capacidade))
                        {
                            Console.Write("Capacidade inválida. Digite novamente: ");
                        }

                        Aviao novoAviao = new Aviao(nome, identificador, modelo, capacidade);
                        filaDescolagem.Enqueue(novoAviao);
                        Console.WriteLine("Avião adicionado à fila de espera.");
                        break;

                    case "4":
                        if (filaDescolagem.Count > 0)
                        {
                            Console.WriteLine("Aviões na fila de espera:");
                            foreach (var aviao in filaDescolagem)
                            {
                                Console.WriteLine(aviao);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há aviões na fila de espera.");
                        }
                        break;

                    case "5":
                        if (filaDescolagem.Count > 0)
                        {
                            Aviao primeiroAviao = filaDescolagem.Peek();
                            Console.WriteLine($"Primeiro avião na fila: {primeiroAviao}");
                        }
                        else
                        {
                            Console.WriteLine("Não há aviões na fila de espera.");
                        }
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
