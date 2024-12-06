

class Program
{

    enum Direcao
    {
        Nulo = 0,
        CimaDireita,
        CimaEsquerda,
        BaixoEsquerda,
        BaixoDireita
    }

    struct Bola
    {
        public int X;
        public int Y;
        public Direcao DirecaoBola;

        public void Desenhar()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("O");
        }

        public void Apagar()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }

    static void Main(string[] args)
    {
        Console.CursorVisible = false;

        Bola bola1;

        bola1.X = 6;
        bola1.Y = 3;
        bola1.DirecaoBola = Direcao.CimaDireita;

        while (!Console.KeyAvailable)
        {
            bola1.Desenhar();

            System.Threading.Thread.Sleep(150);

            bola1.Apagar();

            if (bola1.DirecaoBola == Direcao.CimaDireita)
            {
                bola1.X++;
                bola1.Y--;
            }

            if (bola1.DirecaoBola == Direcao.BaixoDireita)
            {
                bola1.X++;
                bola1.Y++;
            }
            
        }

    }

}




