public struct DadosAutomovel
{
    public string Marca;
    public int Modelo;
    public double Preco;
    public string Matricula;
    public int AnoMatricula;
    public int Quilometragem;
    public int Cilindrada;
    public string Combustivel;
    public string Cor;
    public int Potencia;
    public int NumeroPortas;
    public bool Ecratatil;

    public DadosAutomovel(string marca, int modelo, double preco, string matricula)
    {
        Marca = marca;
        Modelo = modelo;
        Preco = preco;
        Matricula = matricula;
        AnoMatricula = 0;
        Quilometragem = 0;
        Cilindrada = 0;
        Combustivel = "";
        Cor = "";
        Potencia = 0;
        NumeroPortas = 0;
        Ecratatil = false;
    }
    static void Main(string[] args)
    {
        DadosAutomovel Viatura1 = new DadosAutomovel("Marca", 107, 6950, "AA-00-BB");

        Viatura1.AnoMatricula = 2012;
        Viatura1.Quilometragem = 116000;
        Viatura1.Cilindrada = 998;
        Viatura1.Combustivel = "Gasolina";
        Viatura1.Cor = "Preto";
        Viatura1.Potencia = 68;
        Viatura1.NumeroPortas = 5;
        Viatura1.Ecratatil = false;


    }
    
        
    
}