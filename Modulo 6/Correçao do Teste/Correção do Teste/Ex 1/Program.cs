using System;
using System.Collections.Generic;
using System.Linq;

// Definição da estrutura de dados para representar um Cliente de Seguros
struct ClienteSeguro
{
    public string Nome;
    public string Localidade;
    public string Telefone;
    public string NumApolice;
    public double Custo;
    public DateTime DataContrato;
}

// Classe principal do programa
class Program
{
    // Lista estática para armazenar os clientes
    static List<ClienteSeguro> clientes = new List<ClienteSeguro>();

    // Método para registrar um novo cliente
    static void RegistarNovoCliente()
    {
        Console.WriteLine("Informe os dados do novo cliente:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Localidade: ");
        string localidade = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        Console.Write("Número da apólice: ");
        string numApolice = Console.ReadLine();
        Console.Write("Custo do seguro: ");
        double custo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Data do contrato (dd/mm/aaaa): ");
        DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        ClienteSeguro novoCliente = new ClienteSeguro
        {
            Nome = nome,
            Localidade = localidade,
            Telefone = telefone,
            NumApolice = numApolice,
            Custo = custo,
            DataContrato = dataContrato
        };

        clientes.Add(novoCliente);
        Console.WriteLine("Cliente registrado com sucesso.\n");
    }

    // Método para listar nomes dos clientes que fizeram seguros em uma certa data
    static void ClientesPorData(DateTime data)
    {
        var clientesNaData = clientes.Where(c => c.DataContrato.Date == data.Date).Select(c => c.Nome).ToList();

        if (clientesNaData.Any())
        {
            Console.WriteLine($"\nClientes que fizeram seguro em {data.ToShortDateString()}:");
            foreach (var nome in clientesNaData)
            {
                Console.WriteLine(nome);
            }
        }
        else
        {
            Console.WriteLine($"\nNenhum cliente fez seguro em {data.ToShortDateString()}.");
        }
    }

    // Método para calcular a percentagem de clientes de uma certa localidade
    static void PercentagemPorLocalidade(string localidade)
    {
        int totalClientes = clientes.Count;
        int clientesNaLocalidade = clientes.Count(c => c.Localidade.Equals(localidade, StringComparison.OrdinalIgnoreCase));

        if (totalClientes > 0)
        {
            double percentagem = (clientesNaLocalidade / (double)totalClientes) * 100;
            Console.WriteLine($"\nPercentagem de clientes de {localidade}: {percentagem:F2}%");
        }
        else
        {
            Console.WriteLine($"\nNenhum cliente encontrado para a localidade {localidade}.");
        }
    }

    // Método para calcular o total dos seguros vendidos
    static void TotalSeguros()
    {
        double total = clientes.Sum(c => c.Custo);
        Console.WriteLine($"\nTotal dos seguros vendidos: R${total:F2}\n");
    }

    // Método para listar todos os dados de um cliente pelo número da apólice
    static void DadosPorApolice(string numApolice)
    {
        var cliente = clientes.FirstOrDefault(c => c.NumApolice.Equals(numApolice, StringComparison.OrdinalIgnoreCase));

        if (cliente.Equals(default(ClienteSeguro)))
        {
            Console.WriteLine($"\nNenhum cliente encontrado com o número da apólice {numApolice}.");
        }
        else
        {
            Console.WriteLine("\nDados do cliente:");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Localidade: {cliente.Localidade}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
            Console.WriteLine($"Número da apólice: {cliente.NumApolice}");
            Console.WriteLine($"Custo do seguro: R${cliente.Custo:F2}");
            Console.WriteLine($"Data do contrato: {cliente.DataContrato.ToShortDateString()}");
        }
    }

    // Método para listar todos os dados de todos os registros em ordem alfabética do nome do cliente
    static void ListarTodos()
    {
        var clientesOrdenados = clientes.OrderBy(c => c.Nome);

        Console.WriteLine("\nTodos os registros de clientes:");
        foreach (var cliente in clientesOrdenados)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Localidade: {cliente.Localidade}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
            Console.WriteLine($"Número da apólice: {cliente.NumApolice}");
            Console.WriteLine($"Custo do seguro: R${cliente.Custo:F2}");
            Console.WriteLine($"Data do contrato: {cliente.DataContrato.ToShortDateString()}\n");
        }
    }

    // Método Main para execução do programa
    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("----- Menu de Opções -----");
            Console.WriteLine("1. Registrar novo cliente");
            Console.WriteLine("2. Listar clientes que fizeram seguro em uma data");
            Console.WriteLine("3. Calcular percentagem de clientes por localidade");
            Console.WriteLine("4. Calcular total dos seguros vendidos");
            Console.WriteLine("5. Listar dados de cliente por número da apólice");
            Console.WriteLine("6. Listar todos os dados de todos os clientes (ordem alfabética)");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    RegistarNovoCliente();
                    break;
                case 2:
                    Console.Write("Informe a data (dd/mm/aaaa): ");
                    DateTime dataConsulta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    ClientesPorData(dataConsulta);
                    break;
                case 3:
                    Console.Write("Informe a localidade: ");
                    string localidadeConsulta = Console.ReadLine();
                    PercentagemPorLocalidade(localidadeConsulta);
                    break;
                case 4:
                    TotalSeguros();
                    break;
                case 5:
                    Console.Write("Informe o número da apólice: ");
                    string numApoliceConsulta = Console.ReadLine();
                    DadosPorApolice(numApoliceConsulta);
                    break;
                case 6:
                    ListarTodos();
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                    break;
            }

        } while (opcao != 0);
    }
}
