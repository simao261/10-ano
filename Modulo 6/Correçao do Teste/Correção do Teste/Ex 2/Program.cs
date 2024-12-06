using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> filaEspera = new Queue<string>(); 

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            
            Console.WriteLine("----- Menu de Opções -----");
            Console.WriteLine("1. Enviar documento para a fila de espera");
            Console.WriteLine("2. Imprimir próximo documento");
            Console.WriteLine("3. Saber o número de documentos em espera");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            
            opcao = Convert.ToInt32(Console.ReadLine());

            
            switch (opcao)
            {
                case 1:
                    EnviarDocumento();
                    break;
                case 2:
                    ImprimirProximoDocumento();
                    break;
                case 3:
                    NumeroDocumentosEspera();
                    break;
                case 4:
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                    break;
            }

        } while (opcao != 4);
    }

    
    static void EnviarDocumento()
    {
        Console.Write("Nome do documento: ");
        string nomeDocumento = Console.ReadLine();

        filaEspera.Enqueue(nomeDocumento);
        Console.WriteLine($"Documento '{nomeDocumento}' enviado para a fila de espera.\n");
    }

   
    static void ImprimirProximoDocumento()
    {
        if (filaEspera.Count > 0)
        {
            string documento = filaEspera.Dequeue();
            Console.WriteLine($"Imprimindo documento '{documento}'.\n");
        }
        else
        {
            Console.WriteLine("Não há documentos na fila de espera para imprimir.\n");
        }
    }

   
    static void NumeroDocumentosEspera()
    {
        int numeroDocumentos = filaEspera.Count;
        Console.WriteLine($"Número de documentos em espera: {numeroDocumentos}\n");
    }
}
