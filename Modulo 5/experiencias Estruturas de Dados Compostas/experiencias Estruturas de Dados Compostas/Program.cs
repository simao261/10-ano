//using System;
//class Program
//{


//    public struct DadosPessoais
//    {
//        public string Nome;
//        public string Morada;
//        public int Idade;
//        public long Telemovel;
//        public string Email;
//    }


//static void Main(string[] args)
//{
//    DadosPessoais cliente1;

//    cliente1.Nome = "Marco Alfredo Sousa";
//    cliente1.Morada = "Avenida Fernão de Magalhães, 107, 3000-001, Coimbra";
//    cliente1.Idade = 33;
//    cliente1.Telemovel = 911234567;
//    cliente1.Email = "marco.sousa16@gmail.com";

//    Console.WriteLine($"Dados do cliente {cliente1.Nome}\n");
//    Console.WriteLine($"Morada: {cliente1.Morada}\nIdade: {cliente1.Idade}\nTelemovel: {cliente1.Telemovel}\nEmail: {cliente1.Email}");
//    Console.ReadKey();

//}

//}


//class Program
//{ 
//public struct DadosPessoais
//{
//    public string Nome;
//    public string Morada;
//    public int Idade;
//    public int Telemovel;
//    public string Email;

//    public DadosPessoais(string nome, string morada, int idade, int telemovel, string email)
//    {
//        Nome = nome;
//        Morada = morada;
//        Idade = idade;
//        Telemovel = telemovel;
//        Email = email;
//    }
//}

//static void Main(string[] args)
//{
//    DadosPessoais cliente2 = new DadosPessoais("Joana Fernandes", "Avenida Miguel Bombarda, 44, 1o Esq., 8500, Portimão", 47, 961234567, "fernandesjoana@gmail.com");

//    Console.WriteLine($"Dados do cliente {cliente2.Nome}\n");
//    Console.WriteLine($"Morada: {cliente2.Morada}\nIdade: {cliente2.Idade}\nTelemóvel: {cliente2.Telemovel}\nEmail: {cliente2.Email}");
//    Console.ReadKey();
//}
//}
//class Program
//{


//    public struct DadosPessoais
//    {
//        public string Nome;
//        public string Morada;
//        public int Idade;
//        public int Telemovel;
//        public string Email;

//        public DadosPessoais(string nome, string morada, int idade, int telemovel, string email)
//        {
//            Nome = nome;
//            Morada = morada;
//            Idade = idade;
//            Telemovel = telemovel;
//            Email = email;
//        }
//    }

//    static void Main(string[] args)
//    {
//        DadosPessoais cliente3 = new DadosPessoais();
//        Console.WriteLine($"Dados do cliente {cliente3.Nome}\n");
//        Console.WriteLine($"Morada: {cliente3.Morada}\nIdade:{ cliente3.Idade}\nTelemóvel: { cliente3.Telemovel}\nEmail: { cliente3.Email}");
//        Console.ReadKey();


//    }


// }





class Program

{

    public enum TipoConsulta
    {
        Limpeza = 1,
        ConsultaNormal = 2,
        Branqueamento = 3,
        Destartarizacao = 4,
    }

    public struct Consulta
    {
        public string Medico;
        public string Paciente;
        public DateTime DataHora;
        public TipoConsulta Tipo;

        public Consulta(string medico, string paciente, DateTime data, TipoConsulta tipo)
        {
            Medico = medico;
            Paciente = paciente;
            DataHora = data;
            Tipo = tipo;
        }


    }
    static void Main(string[] args)
    {
        Consulta consulta1;

        consulta1.Medico = "Dr. Marcos Cruz";
        consulta1.Paciente = "Simão Rodrigues";
        consulta1.DataHora = new DateTime(2024, 04, 10, 10, 59, 00);
        consulta1.Tipo = TipoConsulta.Branqueamento;
        Consulta consulta2 = new Consulta ("Dr. Marcos Cruz", "iara vaz", new DateTime (2024, 04, 10, 10, 59, 00), TipoConsulta.ConsultaNormal);
        
    }

}










