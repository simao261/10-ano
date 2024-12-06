using System;
using System.Collections.Generic;

namespace _2_Programa

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Browser navegador = Browser.Inicializar();

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Abrir página");
                Console.WriteLine("2 - Voltar atrás");
                Console.WriteLine("3 - Avançar");
                Console.WriteLine("4 - Voltar atrás várias vezes");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");

                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {

                    case 1:
                        Console.Write("Digite o link da página: ");
                        string linkPagina = Console.ReadLine();
                        navegador.AbrePagina(linkPagina);
                        break;
                    case 2:
                        navegador.VoltaAtras();
                        break;
                    case 3:
                        navegador.AndaFrente();
                        break;
                    case 4:
                        Console.Write("Digite o número de vezes para voltar atrás: ");
                        int n;
                        if (!int.TryParse(Console.ReadLine(), out n))
                        {
                            Console.WriteLine("Número inválido. Tente novamente.");
                            continue;
                        }
                        navegador.VoltaAtrasNVezes(n);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        public struct Browser
        {
            public string paginaAtiva;
            public Stack<string> historicoAnterior;
            public Stack<string> historicoSeguinte;

            public static Browser Inicializar()
            {
                Browser navegador = new Browser
                {
                    paginaAtiva = "Nenhuma",
                    historicoAnterior = new Stack<string>(),
                    historicoSeguinte = new Stack<string>()
                };
                return navegador;
            }

            public void AbrePagina(string linkPagina)
            {
                if (paginaAtiva != "Nenhuma")
                {
                    historicoAnterior.Push(paginaAtiva);
                }
                paginaAtiva = linkPagina;
                historicoSeguinte.Clear();
                Console.WriteLine($"Página atual: {paginaAtiva}");
            }

            public void VoltaAtras()
            {
                if (historicoAnterior.Count > 0)
                {
                    historicoSeguinte.Push(paginaAtiva);
                    paginaAtiva = historicoAnterior.Pop();
                    Console.WriteLine($"Página atual: {paginaAtiva}");
                }
                else
                {
                    Console.WriteLine("Histórico para trás está vazio.");
                }
            }

            public void AndaFrente()
            {
                if (historicoSeguinte.Count > 0)
                {
                    historicoAnterior.Push(paginaAtiva);
                    paginaAtiva = historicoSeguinte.Pop();
                    Console.WriteLine($"Página atual: {paginaAtiva}");
                }
                else
                {
                    Console.WriteLine("Histórico para a frente está vazio.");
                }
            }

            public void VoltaAtrasNVezes(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (historicoAnterior.Count > 0)
                    {
                        historicoSeguinte.Push(paginaAtiva);
                        paginaAtiva = historicoAnterior.Pop();
                        Console.WriteLine($"Página atual: {paginaAtiva}");
                    }
                    else
                    {
                        Console.WriteLine("Histórico para trás está vazio.");
                        break;
                    }
                }
            }
        }
    }
}
