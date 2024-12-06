ConsoleKeyInfo tecla;
Console.WriteLine("Pressione uma das seguintes teclas:");
Console.WriteLine(" 1: Calcular o quadrado de um Nº");
Console.WriteLine(" 2: Converter de Cº para Fº");
Console.WriteLine(" 3: Somar três Números");
Console.WriteLine(" 4: Defenir qual é o maior Nº");
Console.WriteLine(" 5: Media dos testes");
Console.WriteLine(" 6: Salário final");
Console.WriteLine(" 7: computador com desconto");
Console.WriteLine(" 8: analisar o impacto de um produto");
Console.WriteLine(" ESC: Terminar o programa");
do
{
    Console.Write("> ");
    tecla = Console.ReadKey();
    Console.WriteLine();
    if (tecla.Key == ConsoleKey.D1)
    {
        Console.WriteLine("Indique um Número: ");
        string N = Console.ReadLine();
        int Num = Convert.ToInt32(N);
        int Y = Num * Num;
        Console.WriteLine("o seu número ao quadrado é: " + Y);
    }
    else if (tecla.Key == ConsoleKey.D2)
    {
        Console.WriteLine("Indique uma Temperatura em Cº:");
        string TC = Console.ReadLine();
        float C = Convert.ToInt32(TC);
        double F = C * 1.8 + 32;
        Console.WriteLine("A sua Temperatura em Fº é: " + F);
        Console.WriteLine("Presione uma tecla para continuar...");
    }
    else if (tecla.Key == ConsoleKey.D3)
    {
        Console.Write("Indique um Número: ");
        string Nume = Console.ReadLine();
        int Numero = Convert.ToInt32(Nume);
        Console.Write("Indique outro Número: ");
        string A = Console.ReadLine();
        int B = Convert.ToInt32(A);
        Console.Write("Indique outro Número: ");
        string C = Console.ReadLine();
        int D = Convert.ToInt32(C);
        int E = Numero + B + D;
        Console.WriteLine("A soma dos três Números é: " + E);
        Console.WriteLine("Presione uma tecla para continuar...");
    }
    else if (tecla.Key == ConsoleKey.D4)
    {
        Console.WriteLine("Indique um Número: ");
        string N1 = Console.ReadLine();
        float N3 = Convert.ToInt32(N1);
        Console.WriteLine("Indique outro Número: ");
        string N2 = Console.ReadLine();
        float N4 = Convert.ToInt32(N2);
        if (N3 > N4)
        {
            Console.WriteLine("O Número " + N3 + " é maior que o Número " + N4);
            Console.WriteLine("Presione uma tecla para continuar...");
        }
        else if (N3 < N4)
        {
            Console.WriteLine("O Número " + N3 + " é menor que o Número " + N4);
            Console.WriteLine("Presione uma tecla para continuar...");
        }
        else if (N3 == N4)
        {
            Console.WriteLine("O Número " + N3 + " é igual ao Número " + N4);
            Console.WriteLine("Presione uma tecla para continuar...");
        }

    }
    else if (tecla.Key == ConsoleKey.D5)
    {
        Console.WriteLine("Indique a nota do 1º teste:");
        string T1 = Console.ReadLine();
        int T3 = Convert.ToInt32(T1);
        Console.WriteLine("Indique a nota do 2º teste:");
        string T2 = Console.ReadLine();
        int T4 = Convert.ToInt32(T2);
        int MT = (T3 + T4) / 2;
        if (MT > 10)
        {
            Console.WriteLine("A sua nota é " + MT + " ou seja passou o módulo");
            Console.WriteLine("Presione uma tecla para continuar...");
        }
        else if (MT < 10)
        {
            Console.WriteLine("A sua nota é " + MT + " ou seja reprovou o módulo");
            Console.WriteLine("Presione uma tecla para continuar...");
        }
    }
    else if (tecla.Key == ConsoleKey.D6)
    {
        Console.Write("Qual é o seu salário base: ");
        string ss = Console.ReadLine();
        int salario = Convert.ToInt32(ss);
        Console.WriteLine("Qual foi o seu valor correspondente ás vendas: ");
        string vv = Console.ReadLine();
        Double vendas = Convert.ToDouble(vv);
        Double final = salario + (vendas * 0.08);
        Console.WriteLine("o seu salário final é: " + final);
        Console.WriteLine("Presione uma tecla para continuar...");
    }
    else if (tecla.Key == ConsoleKey.D7)
    {
        Console.WriteLine("Indique o preço do computador: ");
        string Price = Console.ReadLine();
        int pric = Convert.ToInt32(Price);
        double priceD = pric * 0.15;
        double priceDe = pric - priceD;
        Console.WriteLine("O preço do computador com 15% desconto é " + priceDe);
        Console.WriteLine("Presione uma tecla para continuar...");
    }
    else if (tecla.Key == ConsoleKey.D8)
    {
        Console.WriteLine("Indique o total de pessoas que participaram:");
        string tpeople = Console.ReadLine();
        int Tpeople = Convert.ToInt32(tpeople);
        //Tpeople Total de pessoas
        Console.WriteLine("Indique o Número de pessoas que gostaram do produto:");
        string gpeople = Console.ReadLine();
        int Gpeople = Convert.ToInt32(gpeople);
        //Gpeople Pessoas que gostaram
        Console.WriteLine("Indique o Número de pessoas que não gostaram do produto:");
        string npeople = Console.ReadLine();
        int Npeople = Convert.ToInt32(npeople);
        //Npeople pessoas que n gostaram
        Console.WriteLine("Indique o Número de pessoas que não responderam do produto:");
        string rpeople = Console.ReadLine();
        int Rpeople = Convert.ToInt32(rpeople);
        //Rpeople Pessoas que n responderam
        int Goodpeople = (Gpeople * 100) / Tpeople;
        Console.WriteLine("De todas as pessoas que participaram " + Goodpeople + "% gostarm do produto.");
        int Nopeople = (Npeople * 100) / Tpeople;
        Console.WriteLine("De todas as pessoas que participaram " + Nopeople + "% não gostarm do produto.");
        int Respeople = (Rpeople * 100) / Tpeople;
        Console.WriteLine("De todas as pessoas que participaram " + Respeople + "% gostarm do produto.");
        Console.ReadKey();
    }

} while (tecla.Key != ConsoleKey.Escape);

