using System;

class Program
{
    static void Main()
    {
        
        Console.Title = "Teste 10PSI2";

       
        Console.Write("Digite seu primeiro nome: ");
        string primeiroNome = Console.ReadLine();

       
        Console.Write("Digite seu último nome: ");
        string ultimoNome = Console.ReadLine();

      
        Console.WriteLine($"Olá, {primeiroNome} {ultimoNome}.");
        Console.ReadKey();
    }
}
