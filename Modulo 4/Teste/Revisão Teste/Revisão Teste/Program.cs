// a)

string[] cores = { "laranja", "verde", "azul", "amarelo", "castanho", "preto" };

// b)


Array.Sort(cores);


Console.WriteLine("cores por ordem ascendente: ");


Array.Sort(cores);
foreach ( string s in cores)
{
    if ( s == cores [cores.Length -1] )
    {
        Console.Write($"\"{s}\" ");
    }
    else
    {
        Console.Write($"\"{s}\" -> ");
    }
    
}

Console.WriteLine();

Console.WriteLine("cores por ordem descendente: ");
Array.Sort(cores);
Array.Reverse(cores);


foreach (string s in cores)
    if (s == cores[cores.Length - 1])
    {
        Console.Write($"\"{s}\" ");
    }
    else
    {
        Console.Write($"\"{s}\" <- ");
    }

// c)


Console.WriteLine();

Console.WriteLine($"\n array inicial: ");
foreach (string s in cores)
{
    Console.Write($"\" {s} \" ");
}

Console.WriteLine();

cores[0] = "Lilás";
cores[cores.Length - 2] = "Rosa";

Console.WriteLine("\n array após as alterações: ");
foreach (string s in cores)
{
    Console.Write($"\" {s} \" ");
}


// 2

// a)
double[] numeros = {1.5, 2.6, 45.3, 3.4, 2.6, -1.5, 5.7};

Console.WriteLine();


// b)

for (int i = 0; i < numeros.Length; i++)

    if (numeros[i] > numeros[numeros.Length - 1])

    {
        Console.WriteLine($"\n {numeros[i]} ");
    }
Console.WriteLine();

//// c

int soma = 0;

foreach (int num in numeros)


    soma += num;
double media = (double)soma / numeros.Length;

Console.WriteLine("Soma dos Elementos: " + soma);

Console.WriteLine();

Console.WriteLine("Média dos Elementos: " + media);

Console.WriteLine();
// d)

double menorvalor = numeros.Min();

double maximovalor = numeros.Max();


Console.WriteLine(" O menor valor é: " + menorvalor);

Console.WriteLine(" O maior valor é: " + maximovalor);

Console.WriteLine();

double indiceUltimoMenor = Array.LastIndexOf(numeros, menorvalor);
double indiceprimeiromenor = Array.IndexOf(numeros, menorvalor);

Console.WriteLine("Índice da última posição do menor valor: " + indiceUltimoMenor);
Console.WriteLine("Índice da primeira posição do menor valor: " + indiceprimeiromenor);

Console.WriteLine();

// grupo 2

// ex 1


{

    {



        int[,] matriz = new int[5, 5];


        for (int i = 0; i < 5; i++)
        {
            matriz[i, i] = 1;
        }


        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

// 3



    {
        
        int[,] algarismos = {
            {0, 1, 2, 3},
            {1, 2, 3, 4},
            {2, 3, 4, 5},
            {3, 4, 5, 6}
        };

        
        int linhas = algarismos.GetLength(0);
        int colunas = algarismos.GetLength(1);

    Console.WriteLine($"numero de linhas: " + linhas);

    Console.WriteLine($"numero de colunas: " + colunas);
    Console.WriteLine();


    int numeroDeElementos = linhas * colunas;

        int soma = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma += algarismos[i, j];
            }
        }

        double media = (double)soma / numeroDeElementos;

        
        Console.WriteLine($"Número de elementos na matriz: {numeroDeElementos}");
        Console.WriteLine($"Média dos elementos na matriz: {media}");
    }


Console.ReadKey();
