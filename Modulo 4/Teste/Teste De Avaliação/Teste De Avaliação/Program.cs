// ex 1

string cidade = string.Empty;

// ex 2

Console.Write("Insira um Texto: ");
string texto = Console.ReadLine();
Console.WriteLine();
texto = texto.ToUpper();

foreach (char c in texto)
{
    Console.Write($"@{c}");
}
Console.WriteLine();

// ex 3
Console.WriteLine();
string s = "q;werty;123";
Console.WriteLine("o Primeiro indice do caracter ; é:  {0}", s.IndexOf(";"));

// Grupo 2

// ex 1

Console.WriteLine();

// a)

string[] formas = { "triângulo", "quadrado", "círculo", "retângulo" };

// ex c)

formas[0] = "hexágono";

// b)

//{
foreach (string forma in formas)


    if (forma != formas[formas.Length - 1])
    {

        Console.Write(forma + ", ");
    }
    else
    {

        Console.Write(forma);
    }


Console.WriteLine();
// d)
Console.WriteLine();
// e)
int[] primos = { 2, 3, 5, 7, 11, 13 };

int soma = 0;
foreach (int num in primos)
{
    soma += num;
}

double media = (double)soma / primos.Length;

Console.Write("Array primos: ");
for (int i = 0; i < primos.Length; i++)
{
    Console.Write(primos[i]);
    if (i < primos.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("");
Console.WriteLine("Soma dos valores: " + soma);
Console.WriteLine("Média dos valores: " + media);
Console.WriteLine();
// ex 2
// a)

Console.WriteLine();

int[,] algarismos =
{
    { 2, 4 , 0 },
    { 3, 9 , 0 },
    { 4, 16, 0 },

};
//b)
//int soma = 0;
//for (int i = 0; i < algarismos.GetLength(0); i++)
//{
//    for (int j = 0; j < algarismos.GetLength(1); j++)
//    {
//        soma += algarismos[i, j];
//    }
//}
//Console.WriteLine("Soma dos números no array: " + soma);


//for (int i = 0; i < algarismos.GetLength(0); i++)
//{
//    algarismos[i, 2] = algarismos[i, 0] * algarismos[i, 1];
//}

//// ex c)
//Console.WriteLine("Matriz após modificação da última coluna:");
//for (int i = 0; i < algarismos.GetLength(0); i++)
//{
//    for (int j = 0; j < algarismos.GetLength(1); j++)
//    {
//        Console.Write(algarismos[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//Console.ReadKey();


Console.ReadKey();