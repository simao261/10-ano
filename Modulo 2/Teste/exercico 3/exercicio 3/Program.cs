using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome da cidade: ");
        string cidade = Console.ReadLine();

        if (cidade == "Buenos Aires")
        {
            Console.WriteLine($"A cidade {cidade} pertence à Argentina.");
            Console.ReadKey();
        }
        else if (cidade == "Maputo")
        {
            Console.WriteLine($"A cidade {cidade} pertence a Moçambique.");
            Console.ReadKey();
        }
        else if (cidade == "Reykjavik")
        {
            Console.WriteLine($"A cidade {cidade} pertence à Islândia.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Cidade não reconhecida.");
            Console.ReadKey();
        }
    }
}
