//Ex 1

public struct DadosCodigoPostal
{
    public int Parte1;
    public int Parte2;
    public string DesignacaoPostal;

    public DadosCodigoPostal(int parte1, int parte2, string designacaopostal)
    {
        Parte1 = parte1;
        Parte2 = parte2;
        DesignacaoPostal = designacaopostal;
    }
}

//Ex 2


public struct DadosPessoais
{
    public int Codigo;
    public string Nome;
    public string Cartaodecidadao;
    public int NIF;
    public string Morada;
    public DadosCodigoPostal DadosCodigoPostal;
    public int NumerodeTelemovel;

    public DadosPessoais(int codigo, string nome, string cartaodecidadao, int nif, string morada, DadosCodigoPostal dadosCodigoPostal, int numerodetelemovel)
    {
        Codigo = codigo;
        Nome = nome;
        Cartaodecidadao = cartaodecidadao;
        NIF = nif;
        Morada = morada;
        DadosCodigoPostal = dadosCodigoPostal;
        NumerodeTelemovel = numerodetelemovel;
    }


    //Ex 5
    static void Main(string[] args)
    {
        DadosPessoais cliente1 = new DadosPessoais(2, "Carla Silva", "87654321 1 XY9", 123456780, "Rua Dom Manuel 1", (3030, 320, "Coimbra"), 911234567);
    }
}



//Ex 3 

public enum TiposFatura
{
    nulo = 0,
    Fatura,
    Faturasimplificada,
    Faturarecibo,
    Notadecredito
}

//Ex 4

public struct Fatura
{
    public int Codigocliente;
    public string NumeroFatura;
    public DateTime DataHora;
    TiposFatura Tipo;


    //Ex 6
    static void Main(string[] args)
    {
        Fatura Fatura1;

        Fatura1.Codigocliente = 2;
        Fatura1.NumeroFatura = "FT 123/2024";
        Fatura1.DataHora = new DateTime(2014, 07, 10, 15, 20, 00);
        Fatura1.Tipo = TiposFatura.Faturarecibo;

    }

}