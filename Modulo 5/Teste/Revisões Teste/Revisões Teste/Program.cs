

//class program
//{
//    // Defenição de uma struct
//    public struct Pessoas
//    {
//        public string nome;
//        public int idade;
//        public string morada;

//        // construtor de uma struct 
//        public Pessoas(string Nome, int Idade, string Morada)
//        {
//            nome = Nome;
//            idade = Idade;
//            morada = Morada;
//        }

//        // Métodos de uma struct
//        public string ObterLocalidade()
//        {
//            return morada.Substring(morada.LastIndexOf(",") + 1);
//        }

//    }

//    static void Main(string[] args)
//    {

//        // Arrays de structs
//        Pessoas[] pessoas7 = new Pessoas[10];

//        pessoas7[0].nome = "André";
//        pessoas7[0].idade = 19;

//        // instaciação de uma struct
//        Pessoas Pessoa1;

//        // Instanciando uma struct Pessoa com o construtor personalizado
//        Pessoas Pessoao0 = new Pessoas("João", 15);

//        // inicialização da struct (Atribuir valores diretamente após a instanciação)
//        Pessoa1.nome = "João";
//        Pessoa1.idade = 17;

//        // Modificar valores dos membros de uma struct 
//        Pessoa1.nome = "João";
//        Pessoa1.idade = 13;

//        // lista de inicialização durante a instanciação
//        Pessoas Pessoa2 = new Pessoas
//        {
//            nome = "simão",
//            idade = 13,
//        };

//        // Aceder aos membros de uma struct
//        Console.WriteLine("informações da Pessoa 1:");
//        Console.WriteLine($"Nome: {Pessoa1.nome} ");
//        Console.WriteLine($"idade: {Pessoa1.idade} ");


//    }






//}

//ex 1

//class programm
//{
//    public struct codigopostal
//    {
//        public int Parte1;
//        public int Parte2;
//        public string CodigoPostal;

//        public codigopostal(int parte1, int parte2, string codigodepostal)
//        {
//            Parte1 = parte1;
//            Parte2 = parte2;
//            CodigoPostal = codigodepostal.ToUpper();
//        }

//        public override string ToString()
//        {
//            return $"{Parte1}-{Parte2} {CodigoPostal}";
//        }

//        static void Main(string[] args)
//        {
//            codigopostal codigo = new codigopostal(3360, 110, "Lorvão");
//            Console.WriteLine(codigo.ToString());
//            Console.ReadKey();

//        }
//    }
//}


//ex soma / media

//int[] alunos = { 2, 5, 9, 23, 57 };

//int soma = 0;

//foreach (int num in alunos)
//{
//    soma += num;
//}

//double media = (double)soma / alunos.Length;

//Console.Write("Array alunos: ");

//for (int i = 0; i < alunos.Length; i++)
//{
//    Console.Write(alunos[1]);
//    if (i < alunos.Length - 1)
//    {
//        Console.Write("-");
//    }
//}

//Console.WriteLine("");
//Console.WriteLine("Soma dos alunos: " + soma);
//Console.WriteLine("Media dos alunos: " + media);
//Console.WriteLine();
//Console.ReadKey();

//// calcular a soma de um array

//int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int somaa = 0;

//foreach (int num in numeros)
//{
//    somaa += num;
//}


// media


//double mediaa = (double)soma / numeros.Length;
//Console.Write("Array Alunos: ");

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write(numeros[i]);
//    if (i < numeros.Length - 1)
//    {
//        Console.Write(".");
//    }
//}
//Console.WriteLine("");
//Console.WriteLine("A soma dos alunos e: " + somaa);
//Console.WriteLine("A média dos alunos e : " + mediaa);
//Console.ReadKey();

// structs
/*class Pogram
{
    public struct Aluno
    {   // defeniçao de uma struct 
        public string nome;
        public string numeroprocesso;
        public int numeroaluno;
        public double classificacaotestematematica;

        // construtor 
        public Aluno(string Nome, string Numeroprocesso, int Numeroaluno, double Classificacaotestematematica)
        {
            nome = Nome;
            numeroprocesso = Numeroprocesso;
            numeroaluno = Numeroaluno;
            classificacaotestematematica = Classificacaotestematematica;
        }

        static void Main(string[] args)
        {   // instancia 
            Aluno aluno1 = new Aluno();
            // inicializando 
            aluno1.nome = "simão";
            aluno1.numeroprocesso = "23456";

            // modificar valores da struct
            aluno1.nome = "joão";
            // arrz§z§ay de uma struct
            Aluno[] aluno2 = new Aluno[10];

            aluno2[0].nome = "rodrigo";
            aluno2[0].numeroprocesso = "a23467";
            // mostrar os valores de uma struct 
            Console.WriteLine($"Nome: {aluno1.nome} \n ");
           
            Console.ReadKey();
        }


        

    }



    
}

// enumeraçoes 


class Pogramm
{

    public enum Tipoconsulta
    {
        limpeza = 1,
        normal = 2,
        branqueamento = 3,
        destartarizacao = 4,
    }
    public struct consulta
    {
        public string Medico;
        public string Nomepaciente;
        public DateTime Datahora;
        public Tipoconsulta Tipo;

        public consulta(string medico , string nomepaciente, DateTime datahora , Tipoconsulta tipo)
        {
            Medico = medico;
            Nomepaciente = nomepaciente;
            Datahora = datahora;
            Tipo = tipo;
        }

        static void Main(string[] args)
        {
            consulta consulta1;
            {
                consulta1.Medico = "Dr.simao";
                consulta1.Datahora = new DateTime(2024, 24, 12);
                consulta1.Tipo = Tipoconsulta.branqueamento;
            }
        }
    }
}*/

//class Pogram
//{
//    public enum Estadosemafero
//    {
//        Verde,
//        vermelho,
//        amarelo,
//        intermitente,
//    }
//}





class Pogram
{
    public enum Tipoconsulta
    {
        Normal,
        avançada,
    }
    public struct Consulta
    {
        public string Nome;
        public int Numeroprocesso;
        public DateTime DataHora;
        public Tipoconsulta Tipo;

        public Consulta(string nome, int numeroprocesso,DateTime datahora, Tipoconsulta tipo)
        {
            Nome = nome;
            Numeroprocesso = numeroprocesso;
            DataHora = datahora;
            Tipo = tipo;
        }
    }

    static void Main(string[] args)
    {
        Consulta Paciente1 = new Consulta("joao", 13455, new DateTime(2024, 02, 29,10,00,00), Tipoconsulta.Normal);


        Console.WriteLine($" Nome: {Paciente1.Nome}");
        Console.WriteLine($"Numero do Processo: {Paciente1.Numeroprocesso}");
        Console.WriteLine($"Datahora: {Paciente1.DataHora}");
        Console.WriteLine($"Tipo de consulta:  ");


        Console.ReadKey();


    }
}
