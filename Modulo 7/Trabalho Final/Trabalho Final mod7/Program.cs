using System.Globalization;
using System.Collections.Generic;

using System.IO;
using System;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;


namespace GestaoProdutosTecnologia
{
    public struct Venda
    {
        public string NomeProduto;
        public int QuantidadeVendida;
        public double PrecoTotal;
        public DateTime DataVenda;

        public Venda(string nomeProduto, int quantidadeVendida, double precoTotal, DateTime dataVenda)
        {
            NomeProduto = nomeProduto;
            QuantidadeVendida = quantidadeVendida;
            PrecoTotal = precoTotal;
            DataVenda = dataVenda;
        }
    }

    public struct Produto
    {
        public string Nome;
        public string Categoria;
        public int Quantidade;
        public double Preco;

        public Produto(string nome, string categoria, int quantidade, double preco)
        {
            Nome = nome;
            Categoria = categoria;
            Quantidade = quantidade;
            Preco = preco;
        }
    }

    public struct Utilizador
    {
        public string Username;
        public string Password;
        public bool IsAdmin;

        public Utilizador(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }
    }

    class Program
    {
        static List<Venda> historicoVendas = new List<Venda>();
        static List<Utilizador> listaUtilizadores = new List<Utilizador>();
        static List<Produto> listaProdutos = new List<Produto>();
        static Dictionary<string, int> quantidadeVendidaPorProduto = new Dictionary<string, int>();
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            

            listaUtilizadores.Add(new Utilizador("simao", "simao26", true));

            CarregarUtilizadores();
            CarregarProdutos();
            CarregarHistoricoVendas();

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                int screenWidth = Console.WindowWidth;
                string option1 = "1 - Iniciar Sessão";
                string option2 = "2 - Criar Conta";
                Console.WriteLine("\n");
                Console.WriteLine(new string(' ', (screenWidth - option1.Length) / 2) + option1);
                Console.WriteLine(new string(' ', (screenWidth - option2.Length) / 2) + option2);
                Console.ResetColor();
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    if (IniciarSessao(out Utilizador user))
                    {
                        if (user.IsAdmin)
                        {
                            MenuAdmin();
                        }
                        else
                        {
                            MenuUtilizador();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Credenciais inválidas. Tente novamente.");
                        Console.ReadKey();
                    }
                }
                else if (opcao == "2")
                {
                    CriarConta();
                }
            }
        }

        static bool IniciarSessao(out Utilizador userLogado)
        {
            listaUtilizadores.Add(new Utilizador("simao", "simao26", true));
            Console.Clear();
            Console.Write("Nome de utilizador: ");
            string username = Console.ReadLine();
            string password = LerPassword();

            foreach (Utilizador user in listaUtilizadores)
            {
                if (user.Username == username && user.Password == password)
                {
                    userLogado = user;
                    return true;
                }
            }
            userLogado = new Utilizador();
            return false;
        }

        static void CriarConta()
        {
            Console.Clear();
            Console.Write("Nome de utilizador: ");
            string username = Console.ReadLine();
            if (listaUtilizadores.Exists(u => u.Username == username))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: A conta já está registada.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }
            string password = LerPassword();
            listaUtilizadores.Add(new Utilizador(username, password, false));
            GravarUtilizadores();
        }

        static string LerPassword()
        {
            string password = "";
            Console.Write("Password: ");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, (password.Length - 1));
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return password;
        }

        static void MenuAdmin()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Menu Produtos");
                Console.WriteLine("2 - Menu Estatísticas");
                Console.WriteLine("3 - Adicionar um novo menbro");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Indique a opção escolhida:");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        MenuProdutos();
                        break;
                    case 2:
                        MenuEstatisticas();
                        break;
                    case 3:
                        Menbros();
                        break;
                    case 4:
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            } while (opc != 3);
        }

        static void MenuProdutos()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Registar produto");
                Console.WriteLine("2 - Ver disponibilidade de produto");
                Console.WriteLine("3 - Vender produto");
                Console.WriteLine("4 - Listar produtos por categoria");
                Console.WriteLine("5 - Atualizar produto");
                Console.WriteLine("6 - Remover produto");
                Console.WriteLine("7 - Pesquisa avançada de produtos");
                Console.WriteLine("8 - Listar todos os produtos por todas as categorias");
                Console.WriteLine("9 - Voltar");
                Console.WriteLine("Indique a opção escolhida:");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        RegistarProduto();
                        break;
                    case 2:
                        VerDisponibilidadeProduto();
                        break;
                    case 3:
                        VenderProduto();
                        break;
                    case 4:
                        ListarProdutosPorCategoria();
                        break;
                    case 5:
                        AtualizarProduto();
                        break;
                    case 6:
                        RemoverProduto();
                        break;
                    case 7:
                        PesquisaAvancadaProdutos();
                        break;
                    case 8:
                        ListarProdutosPorTodasCategorias();
                        break;
                    case 9:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opc != 9);
        }

        static void MenuEstatisticas()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Verificar Estoque Baixo");
                Console.WriteLine("2 - Exibir Estatísticas Gerais");
                Console.WriteLine("3 - Backup dos Dados");
                Console.WriteLine("4 - Apagar Todos os Dados");
                Console.WriteLine("5 - Voltar");
                Console.Write("Indique a opção escolhida: ");

                string opcao = Console.ReadLine().Trim();

                switch (opcao)
                {
                    case "1":
                        VerificarEstoqueBaixo();
                        break;
                    case "2":
                        ExibirEstatisticas();
                        break;
                    case "3":
                        BackupDados();
                        break;
                    case "4":
                        ApagarTodosOsDados();
                        break;
                    case "5":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }
        }

    

    static void MenuUtilizador()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Comprar produto");
                Console.WriteLine("2 - Pesquisar produto por nome, categoria ou preço");
                Console.WriteLine("3 - Ver todas os produtos");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Indique a opção escolhida:");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        VenderProduto();
                        break;
                    case 2:
                        PesquisaAvancadaProdutos();
                        break;
                    case 3:
                        ListarProdutosPorTodasCategorias();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opc != 4);
        }

        static void RegistarProduto()
        {
            Console.Clear();
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Categoria: ");
            string categoria = Console.ReadLine();
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            double preco = 0;
            bool precoValido = false;
            while (!precoValido)
            {
                Console.Write("Preço: ");
                if (double.TryParse(Console.ReadLine(), out preco))
                {
                    precoValido = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Preço inválido. Por favor, insira um valor numérico.");
                    Console.ResetColor();
                }
            }

            listaProdutos.Add(new Produto(nome, categoria, quantidade, preco));
            GravarProdutos();
        }

        static void VerDisponibilidadeProduto()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Produto? produto = listaProdutos.FirstOrDefault(p => p.Nome == nome);

            if (produto.HasValue)
            {
                Console.WriteLine($"Produto: {produto.Value.Nome}");
                Console.WriteLine($"Categoria: {produto.Value.Categoria}");
                Console.WriteLine($"Quantidade: {produto.Value.Quantidade}");
                Console.WriteLine($"Preço: {produto.Value.Preco}€");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
            Console.ReadKey();
        }

        static void VenderProduto()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Produto? produto = listaProdutos.FirstOrDefault(p => p.Nome == nome);

            if (produto.HasValue)
            {
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (produto.Value.Quantidade >= quantidade)
                {
                    listaProdutos.Remove(produto.Value);
                    produto = new Produto(produto.Value.Nome, produto.Value.Categoria, produto.Value.Quantidade - quantidade, produto.Value.Preco);
                    listaProdutos.Add(produto.Value);
                    double precoTotal = quantidade * produto.Value.Preco;
                    historicoVendas.Add(new Venda(nome, quantidade, precoTotal, DateTime.Now));

                    if (quantidadeVendidaPorProduto.ContainsKey(nome))
                    {
                        quantidadeVendidaPorProduto[nome] += quantidade;
                    }
                    else
                    {
                        quantidadeVendidaPorProduto[nome] = quantidade;
                    }

                    Console.WriteLine($"Venda concluída. Preço total: {precoTotal}€");
                    GravarProdutos();
                    CarregarHistoricoVendas();
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente em estoque.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
            Console.ReadKey();
        }

        static void ListarProdutosPorCategoria()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.Write("Categoria: ");
            string categoria = Console.ReadLine();

            var produtosPorCategoria = listaProdutos.Where(p => p.Categoria == categoria).ToList();

            if (produtosPorCategoria.Count > 0)
            {
                foreach (var produto in produtosPorCategoria)
                {
                    Console.WriteLine($"Produto: {produto.Nome}");
                    Console.WriteLine($"Quantidade: {produto.Quantidade}");
                    Console.WriteLine($"Preço: {produto.Preco}€");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto encontrado para essa categoria.");
            }
            Console.ReadKey();
        }

        static void AtualizarProduto()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.Write("Nome do produto a atualizar: ");
            string nome = Console.ReadLine();
            Produto? produto = listaProdutos.FirstOrDefault(p => p.Nome == nome);

            if (produto.HasValue)
            {
                listaProdutos.Remove(produto.Value);

                Console.Write("Novo nome (deixe em branco para manter): ");
                string novoNome = Console.ReadLine();
                if (!string.IsNullOrEmpty(novoNome))
                {
                    produto = new Produto(novoNome, produto.Value.Categoria, produto.Value.Quantidade, produto.Value.Preco);
                }

                Console.Write("Nova categoria (deixe em branco para manter): ");
                string novaCategoria = Console.ReadLine();
                if (!string.IsNullOrEmpty(novaCategoria))
                {
                    produto = new Produto(produto.Value.Nome, novaCategoria, produto.Value.Quantidade, produto.Value.Preco);
                }

                Console.Write("Nova quantidade (deixe em branco para manter): ");
                string novaQuantidade = Console.ReadLine();
                if (int.TryParse(novaQuantidade, out int quantidade))
                {
                    produto = new Produto(produto.Value.Nome, produto.Value.Categoria, quantidade, produto.Value.Preco);
                }

                Console.Write("Novo preço (deixe em branco para manter): ");
                string novoPreco = Console.ReadLine();
                if (double.TryParse(novoPreco, out double preco))
                {
                    produto = new Produto(produto.Value.Nome, produto.Value.Categoria, produto.Value.Quantidade, preco);
                }

                listaProdutos.Add(produto.Value);
                GravarProdutos();
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
            Console.ReadKey();
        }

        static void RemoverProduto()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.Write("Nome do produto a remover: ");
            string nome = Console.ReadLine();
            Produto? produto = listaProdutos.FirstOrDefault(p => p.Nome == nome);

            if (produto.HasValue)
            {
                listaProdutos.Remove(produto.Value);
                GravarProdutos();
                Console.WriteLine("Produto removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
            Console.ReadKey();
        }

        static void PesquisaAvancadaProdutos()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine("===== Pesquisa Avançada de Produtos =====");
            Console.WriteLine("1 - Por Nome");
            Console.WriteLine("2 - Por Categoria");
            Console.WriteLine("3 - Por Faixa de Preço");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            IEnumerable<Produto> produtosEncontrados = null;
            Console.Clear();
            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    produtosEncontrados = listaProdutos.Where(p => p.Nome.IndexOf(nome, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "2":
                    Console.Write("Categoria: ");
                    string categoria = Console.ReadLine();
                    produtosEncontrados = listaProdutos.Where(p => p.Categoria.IndexOf(categoria, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "3":
                    Console.Write("Preço mínimo: ");
                    double precoMinimo = double.Parse(Console.ReadLine());
                    Console.Write("Preço máximo: ");
                    double precoMaximo = double.Parse(Console.ReadLine());
                    produtosEncontrados = listaProdutos.Where(p => p.Preco >= precoMinimo && p.Preco <= precoMaximo);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (produtosEncontrados != null && produtosEncontrados.Any())
            {
                Console.WriteLine("Produtos encontrados:");
                foreach (var produto in produtosEncontrados)
                {
                    Console.WriteLine($"Nome: {produto.Nome}, Categoria: {produto.Categoria}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}€");
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto encontrado com os critérios especificados.");
            }

            Console.WriteLine();

            Console.ReadKey();
        }


        static void ListarProdutosPorTodasCategorias()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }
            Console.Clear();
            var produtosPorCategoria = listaProdutos.GroupBy(p => p.Categoria);

            foreach (var categoriaGroup in produtosPorCategoria)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Categoria: {categoriaGroup.Key}");
                Console.ResetColor();
                foreach (var produto in categoriaGroup)
                {
                    Console.WriteLine($"Produto: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}€");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        



        static void VerificarEstoqueBaixo()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            Console.Clear();
            var produtosBaixoEstoque = listaProdutos.Where(p => p.Quantidade < 10).ToList();

            if (produtosBaixoEstoque.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Produtos com estoque baixo:");
                foreach (var produto in produtosBaixoEstoque)
                {
                    Console.WriteLine($"Produto: {produto.Nome}, Quantidade: {produto.Quantidade}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto com estoque baixo.");
            }
            Console.ReadKey();
        }

        static void ExibirEstatisticas()
        {
            if (listaProdutos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Não há nenhum produto registrado.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }
            Console.Clear();

            var totalVendas = historicoVendas.Count;
            var totalProdutos = listaProdutos.Count;
            var totalValorVendas = historicoVendas.Sum(v => v.PrecoTotal);
            var totalValorEstoque = listaProdutos.Sum(p => p.Quantidade * p.Preco);

            Console.WriteLine($"Total de vendas realizadas: {totalVendas}");
            Console.WriteLine($"Total de produtos registrados: {totalProdutos}");
            Console.WriteLine($"Total de valor em vendas: {totalValorVendas.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Total de valor em estoque: {totalValorEstoque.ToString("C", CultureInfo.CurrentCulture)}");

            if (historicoVendas.Count > 0)
            {
                var produtoMaisVendido = historicoVendas
                    .GroupBy(v => v.NomeProduto)
                    .OrderByDescending(g => g.Sum(v => v.QuantidadeVendida))
                    .FirstOrDefault();

                if (produtoMaisVendido != null)
                {
                    Console.WriteLine($"Produto mais vendido: {produtoMaisVendido.Key}, Quantidade: {produtoMaisVendido.Sum(v => v.QuantidadeVendida)}");
                }
            }

            if (historicoVendas.Count > 0)
            {
                var categoriaMaisVendida = historicoVendas
                    .Join(listaProdutos, venda => venda.NomeProduto, produto => produto.Nome, (venda, produto) => new { venda, produto.Categoria })
                    .GroupBy(v => v.Categoria)
                    .Select(grupo => new
                    {
                        Categoria = grupo.Key,
                        QuantidadeVendida = grupo.Sum(v => v.venda.QuantidadeVendida)
                    })
                    .OrderByDescending(c => c.QuantidadeVendida)
                    .FirstOrDefault();

                if (categoriaMaisVendida != null)
                {
                    Console.WriteLine($"Categoria mais vendida: {categoriaMaisVendida.Categoria}, Quantidade: {categoriaMaisVendida.QuantidadeVendida}");
                }
            }

            if (historicoVendas.Count > 0)
            {
                Console.WriteLine("\nTodos os produtos vendidos:");
                foreach (var venda in historicoVendas)
                {
                    Console.WriteLine($"Produto: {venda.NomeProduto}, Quantidade Vendida: {venda.QuantidadeVendida}, Valor Total: {venda.PrecoTotal.ToString("C", CultureInfo.CurrentCulture)}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto foi vendido.");
            }

            Console.WriteLine("\nTodos os produtos registrados:");
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Categoria: {produto.Categoria}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco.ToString("C", CultureInfo.CurrentCulture)}");
            }

            Console.ReadKey();
        }





        static void Menbros()
        {
            while (true)
            {
                Console.Clear();


                Console.WriteLine();

                Console.WriteLine("1. Adicionar um Utilizador");
                Console.WriteLine("2. Adicionar um Administrador");
                Console.WriteLine("3. Listar Utilizadores Registrados");
                Console.WriteLine("4. Remover Utilizador ou Administrador");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine().Trim();

                switch (opcao)
                {
                    case "1":
                        AdicionarUtilizador(false);
                        break;
                    case "2":
                        AdicionarUtilizador(true);
                        break;
                    case "3":
                        ListarUtilizadores();
                        break;
                    case "4":
                        RemoverUtilizadorOuAdministrador();
                        break;
                    case "0":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void AdicionarUtilizador(bool isAdmin)
        {
            Console.Clear();
            Console.WriteLine($"Adicionar novo {(isAdmin ? "Administrador" : "Utilizador")}:");
            Console.WriteLine();

            Console.Write("Nome de Utilizador: ");
            string username = Console.ReadLine().Trim();

            if (listaUtilizadores.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Este nome de Utilizador já está em uso.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            Console.Write("Senha: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            listaUtilizadores.Add(new Utilizador(username, password, isAdmin));

            GravarUtilizadores();
            Console.WriteLine();

            if (isAdmin)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Novo Administrador adicionado com sucesso.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Novo Utilizador adicionado com sucesso.");
            }

            Console.ResetColor();
            Console.ReadKey();
        }

        static void ListarUtilizadores()
        {
            Console.Clear();
            Console.WriteLine("Utilizadores Registrados:");


            var utilizadoresComuns = listaUtilizadores.Where(u => !u.IsAdmin).ToList();
            var administradores = listaUtilizadores.Where(u => u.IsAdmin).ToList();

            if (utilizadoresComuns.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Utilizadores:");
                Console.ResetColor();
                foreach (var utilizador in utilizadoresComuns)
                {
                    Console.WriteLine($"- {utilizador.Username}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Utilizador comum registrado.");
            }

            Console.WriteLine();

            if (administradores.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Administradores:");
                Console.ResetColor();
                foreach (var admin in administradores)
                {
                    Console.WriteLine($"- {admin.Username}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Administrador registrado.");
            }

            Console.ReadKey();
        }

        static void RemoverUtilizadorOuAdministrador()
        {
            Console.Clear();
            Console.WriteLine("Remover Utilizador ou Administrador:");

            Console.WriteLine();
            Console.Write("Nome de Utilizador a remover: ");
            string username = Console.ReadLine().Trim();

            bool utilizadorEncontrado = false;


            foreach (var utilizador in listaUtilizadores.ToList())
            {
                if (utilizador.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    listaUtilizadores.Remove(utilizador);
                    utilizadorEncontrado = true;
                    GravarUtilizadores();


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Utilizador/Administrador '{username}' removido com sucesso.");
                    Console.ResetColor();

                    break;
                }
            }


            if (!utilizadorEncontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não foi encontrado nenhum Utilizador/Administrador com o nome '{username}'.");
                Console.ResetColor();
            }

            Console.ReadKey();
        }



        static void GravarProdutos()
        {
            using (FileStream fs = new FileStream("produtos.dat", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(listaProdutos.Count);
                foreach (var produto in listaProdutos)
                {
                    writer.Write(produto.Nome.Length);
                    writer.Write(produto.Nome);
                    writer.Write(produto.Categoria.Length);
                    writer.Write(produto.Categoria);
                    writer.Write(produto.Quantidade);
                    writer.Write(produto.Preco);
                }
            }
        }
        static void CarregarProdutos()
        {
            listaProdutos.Clear();
            if (File.Exists("produtos.dat"))
            {
                try
                {
                    using (FileStream fs = new FileStream("produtos.dat", FileMode.Open))
                    using (BinaryReader reader = new BinaryReader(fs))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            int nomeLength = reader.ReadInt32();
                            var nome = new string(reader.ReadChars(nomeLength));
                            int categoriaLength = reader.ReadInt32();
                            var categoria = new string(reader.ReadChars(categoriaLength));
                            var quantidade = reader.ReadInt32();
                            var preco = reader.ReadDouble();
                            listaProdutos.Add(new Produto(nome, categoria, quantidade, preco));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Erro inesperado ao carregar produtos: {ex.Message}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Aviso: O arquivo de produtos não foi encontrado. Nenhum produto foi carregado.");
                Console.ResetColor();
            }
        }



        static void GravarUtilizadores()
        {
            using (FileStream fs = new FileStream("utilizadores.dat", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(listaUtilizadores.Count);
                foreach (var user in listaUtilizadores)
                {
                    
                    writer.Write(user.Username.Length);
                    writer.Write(user.Username.ToCharArray());

                   
                    writer.Write(user.Password.Length);
                    writer.Write(user.Password.ToCharArray());

                    
                    writer.Write(user.IsAdmin);
                }
            }
        }



        static void CarregarUtilizadores()
        {
            listaUtilizadores.Clear();
            if (File.Exists("utilizadores.dat"))
            {
                try
                {
                    using (FileStream fs = new FileStream("utilizadores.dat", FileMode.Open))
                    using (BinaryReader reader = new BinaryReader(fs))
                    {
                        int count = reader.ReadInt32();
                        for (int i = 0; i < count; i++)
                        {
                            int usernameLength = reader.ReadInt32();
                            var username = new string(reader.ReadChars(usernameLength));

                            int passwordLength = reader.ReadInt32();
                            var password = new string(reader.ReadChars(passwordLength));

                            bool isAdmin = reader.ReadBoolean();

                            listaUtilizadores.Add(new Utilizador(username, password, isAdmin));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Erro ao carregar utilizadores: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }








        static void CarregarHistoricoVendas()
        {
            historicoVendas.Clear();
            if (File.Exists("historicoVendas.dat"))
            {
                try
                {
                    using (FileStream fs = new FileStream("historicoVendas.dat", FileMode.Open))
                    using (BinaryReader reader = new BinaryReader(fs))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            int nomeProdutoLength = reader.ReadInt32();
                            var nomeProduto = new string(reader.ReadChars(nomeProdutoLength));
                            var quantidadeVendida = reader.ReadInt32();
                            var precoTotal = reader.ReadDouble();
                            var dataVenda = DateTime.FromBinary(reader.ReadInt64());
                            historicoVendas.Add(new Venda(nomeProduto, quantidadeVendida, precoTotal, dataVenda));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Erro ao carregar histórico de vendas: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }

        static void GravarHistoricoVendas()
        {
            using (FileStream fs = new FileStream("historicoVendas.dat", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(historicoVendas.Count);
                foreach (var venda in historicoVendas)
                {
                    writer.Write(venda.NomeProduto.Length);
                    writer.Write(venda.NomeProduto.ToCharArray());
                    writer.Write(venda.QuantidadeVendida);
                    writer.Write(venda.PrecoTotal);
                    writer.Write(venda.DataVenda.ToBinary());
                }
            }
        }

        static void BackupDados()
        {
            Console.Clear();
            string backupDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backup");

            if (!Directory.Exists(backupDir))
            {
                Directory.CreateDirectory(backupDir);
            }

           
            string produtosFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "produtos.dat");
            string utilizadoresFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utilizadores.dat");
            string historicoVendasFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "historicoVendas.dat");

            try
            {
                if (File.Exists(produtosFile))
                {
                    File.Copy(produtosFile, Path.Combine(backupDir, "produtos_backup.dat"), true);
                }

                if (File.Exists(utilizadoresFile))
                {
                    File.Copy(utilizadoresFile, Path.Combine(backupDir, "utilizadores_backup.dat"), true);
                }

                if (File.Exists(historicoVendasFile))
                {
                    File.Copy(historicoVendasFile, Path.Combine(backupDir, "historicoVendas_backup.dat"), true);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Backup realizado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro ao realizar backup: {ex.Message}");
            }
            finally
            {
                Console.ResetColor();
            }

            Console.ReadKey();
        }


        static void ApagarTodosOsDados()
        {
            Console.Clear();
            listaProdutos.Clear();
            listaUtilizadores.Clear();
            historicoVendas.Clear();

            GravarProdutos();
            GravarUtilizadores();
            GravarHistoricoVendas();

            AdicionarAdministradorPadrao();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Todos os dados foram apagados e um administrador padrão foi adicionado.");
            Console.ResetColor();
            Console.ReadKey();
        }

        static void AdicionarAdministradorPadrao()
        {
            try
            {
                CarregarUtilizadores(); 

                if (!listaUtilizadores.Any(u => u.IsAdmin))
                {
                    listaUtilizadores.Add(new Utilizador("simao", "simao26", true));

                    GravarUtilizadores(); 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Administrador padrão adicionado com sucesso.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Já existe pelo menos um administrador na lista.");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro ao adicionar administrador padrão: {ex.Message}");
            }
            finally
            {
                Console.ResetColor();
                Console.ReadKey();
            }
        }





    }
}

