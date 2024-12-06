using System;

class Program
{
    static void Main()
    {
        int numero = 10;

        while (numero >= -26)
        {
            Console.WriteLine($">{numero}");
            numero -= 2;
          
        }
        Console.ReadKey();
    }
}
