// Ficha 3

// ex 1

// a)

//string[,] equipas = new string[6, 3]

//{
//    { "Ana" , "Claudia" , ""},
//    { "catarina", "Andre", "miguel"},
//    { "Paulo" , "miguel", "maria"},
//    { "" , "" ,  "" },
//    { "" , "" ,  "" },
//    { "" , "" ,  "" }
//};

////b)

//for (int linha = equipas.GetLength(0) - 1; linha >= 0; --linha)
//{
//    for (int coluna = equipas.GetLength(1) - 1; coluna >= 0; --coluna)
//    {
//        Console.WriteLine(equipas[linha, coluna]);
//    }
//}

//Console.ReadKey();

// ex 2

//int i = 0;
//string[,] nomes = new string[3, 3]
//{
//    { "Ana", "Claudia", "Carlos"},
//    { "André", "António", "Bárbara"},
//    { "Matilde", "André", "Tânia"},
//};
//foreach (string s in nomes)
//{

//    if (i == nomes.Length - 1)
//    {
//        Console.Write($"'{s}'");
//    }
//    else
//    {
//        Console.Write($"'{s}'-");
//    }
//    i++;
//}

//Console.ReadKey();

// ex 3

//double[,] temperaturas = {
//    {30, 30.1, 29.6, 27, 33.6, 32.8, 32.9, 32.7},
//    {32.6, 32, 31.8, 31.7, 31.9, 26.5, 26.5, 26.5},
//    {28.2, 28, 28, 28.1, 28, 29, 28.8, 28.9}
//};


//for (int i = 0; i < temperaturas.GetLength(0); i++)
//{
//    double soma = 0;
//    Console.WriteLine($"Temperaturas do dia {i + 1}: ");
//    for (int j = 0; j < temperaturas.GetLength(1); j++)
//    {
//        Console.Write(temperaturas[i, j] + " ");
//        soma += temperaturas[i, j];
//    }
//    double media = soma / temperaturas.GetLength(1);
//    Console.WriteLine($"\nMédia: {media:F2}\n");
//}


//double menorTemperatura = temperaturas[0, 0];
//double maiorTemperatura = temperaturas[0, 0];
//int linhaMenor = 0, colunaMenor = 0, linhaMaior = 0, colunaMaior = 0;

//for (int i = 0; i < temperaturas.GetLength(0); i++)
//{
//    for (int j = 0; j < temperaturas.GetLength(1); j++)
//    {
//        if (temperaturas[i, j] < menorTemperatura)
//        {
//            menorTemperatura = temperaturas[i, j];
//            linhaMenor = i;
//            colunaMenor = j;
//        }

//        if (temperaturas[i, j] > maiorTemperatura)
//        {
//            maiorTemperatura = temperaturas[i, j];
//            linhaMaior = i;
//            colunaMaior = j;
//        }
//    }
//}

//Console.WriteLine($"Menor temperatura: {menorTemperatura} [{linhaMenor + 1}, {colunaMenor + 1}]");

//Console.WriteLine($"Maior temperatura: {maiorTemperatura} [{linhaMaior + 1}, {colunaMaior + 1}]");
//Console.ReadKey();

// ex 4

//int[,] A = new int[5, 5];
//int[,] B = new int[5, 5];
//int[,] C = new int[5, 5];
//Random rnd = new Random();

//for (int i = 0; i < A.GetLength(0); ++i) 

//{
//    for (int j = 0; j < A.GetLength(1); ++j)
//    {
//        A[i, j] = rnd.Next(1, 11);
//        B[i, j] = rnd.Next(1, 11);
//    }
//}

//for (int i = 0; i < A.GetLength(0); ++i)
//{
//    for (int j = 0; j < A.GetLength(1); ++j)
//    {
//        C[i, j] = A[i, j] + B[i, j];
//    }
//}
//Console.WriteLine("Array A = ");
//for (int i = 0; i < A.GetLength(0); ++i)
//{
//    for (int j = 0; j < A.GetLength(1); ++j)
//    {
//        Console.Write("{0,2:#0} ", A[i, j]);
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("\nArray B = ");
//for (int i = 0; i < B.GetLength(0); ++i)
//{
//    for (int j = 0; j < B.GetLength(1); ++j)
//    {

//        Console.Write("{0,2:#0} ", B[i, j]);
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("\nArray C = ");
//for (int i = 0; i < C.GetLength(0); ++i)
//{
//    for (int j = 0; j < C.GetLength(1); ++j)
//    {
//        Console.Write("{0,2:#0} ", C[i, j]);
//    }

//}    Console.ReadKey();