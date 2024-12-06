

// ex 1
string nome;
Console.Write("Insira o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine($"O seu nome é {nome}");

//ex 2
string frase = "Coimbra é a cidade portuguesa capital do Distrito de Coimbra.";
for (int i = 0; i < frase.Length - 1; ++i)
{
    Console.Write($"{frase[i]} ");
}

// ex 3
string frase = "";
Console.Write("Insira uma frase: ");
frase = Console.ReadLine();
Console.Write("\nFrase invertida: ");
for (int i = frase.Length - 1; i >= 0; --i)
{
    Console.Write(frase[i]);

}

Console.ReadKey();
