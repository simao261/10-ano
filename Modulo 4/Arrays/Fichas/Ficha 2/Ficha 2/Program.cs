// Ficha 2

// 1


using System;

String[] paises = { "Portugal", "Espanha", "França", "Estados Unidos da América", "Alemanha", "Afeganistão", "Moçambique", "China", "Itália" };

double[] temperaturas = { 10, 10, 9, 9.8, 10.5, -8.7, 13, 9, 14, 14.1, 13.9, 12, 12.1, 15 };

Decimal[] precos = { 25.95M, 15.95M, 7.10M, 12.99M, 9.32M, 11.65M, 17.73M };


// ex 2

Console.Write("Conteúdo do array paises: ");

for (int i = 0; i < paises.Length; ++i)

    Console.Write(" \"" + paises[i] + "\"");

Console.WriteLine("Conteúdo do array temperaturas: ");

for (int i = 0; i < temperaturas.Length; ++i)

    Console.Write($"{temperaturas[i]}º - ");


Console.WriteLine("\n\nConteúdo do array precos: ");
for (int i = 0, saltar = 1; i < precos.Length; i++)
{
    if (saltar != 3)
    {
        Console.Write($"{precos[i]}€/");
    }
    else
    {
        Console.Write($"{precos[i]}€");
        Console.WriteLine(); 
        saltar = 0; 
    }
    saltar++;
}

Console.Write('\n');

Console.WriteLine();

// ex 3


        Array.Reverse(paises);

        for (int i = 0; i < paises.Length; i++)
        {
            Console.WriteLine($" {paises.Length - i - 1}. {paises[i]}");
        }

Console.WriteLine();

// ex 4
Random rnd = new Random();

string[] alunos = { "Ana", "André", "Beatriz", "Bernardo", "Cláudia", "Catarina", "Gilberto", "Marco", "Tatiana", "Teresa", "Vítor" };

double[] classificacoesTeste1 = new double[alunos.Length];

    {
        
      

       
        for (int i = 0; i < alunos.Length; i++)
        {
            
            double classificacao = Math.Round(rnd.NextDouble() * (20 - 5) + 5, 1);
            classificacoesTeste1[i] = classificacao;
        }

        
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Nº {i + 1}, \"{alunos[i]}\": {classificacoesTeste1[i]} valores");
        }
    }


Console.WriteLine();

// ex 5


{
        

       
        double temperaturaMinima = temperaturas[0];
        double temperaturaMaxima = temperaturas[0];
        double somaDasTemperaturas = 0;

        
        foreach (double temperatura in temperaturas)
        {
            if (temperatura < temperaturaMinima)
            {
                temperaturaMinima = temperatura;
            }

            
            if (temperatura > temperaturaMaxima)
            {
                temperaturaMaxima = temperatura;
            }

            
            somaDasTemperaturas += temperatura;
        }

       
        double mediaDasTemperaturas = somaDasTemperaturas / temperaturas.Length;

        
        int temperaturasAbaixoDaMedia = 0;
        int temperaturasAcimaDaMedia = 0;

        
        foreach (double temperatura in temperaturas)
        {
            if (temperatura < mediaDasTemperaturas)
            {
                temperaturasAbaixoDaMedia++;
            }
            else if (temperatura > mediaDasTemperaturas)
            {
                temperaturasAcimaDaMedia++;
            }
        }

        
        Console.WriteLine($"Temperatura mínima: {temperaturaMinima}");
        Console.WriteLine($"Temperatura máxima: {temperaturaMaxima}");
        Console.WriteLine($"Soma das temperaturas: {somaDasTemperaturas}");
        Console.WriteLine($"Média das temperaturas: {mediaDasTemperaturas}");
        Console.WriteLine($"Temperaturas abaixo da média: {temperaturasAbaixoDaMedia}");
        Console.WriteLine($"Temperaturas acima da média: {temperaturasAcimaDaMedia}");
    }

Console.WriteLine();

// ex 6

// ex 7






Console.ReadKey();



string nome = nome.ToUpper();
Console.WriteLine();
Console.WriteLine("insira o seu nome: " + nome);
