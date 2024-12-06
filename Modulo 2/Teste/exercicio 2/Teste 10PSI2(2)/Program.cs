using System;

class Program
{
    static void Main()
    {
      
        Console.ForegroundColor = ConsoleColor.Yellow;

        
        Console.Write("Insira a temperatura em graus Celsius: ");

        
        if (double.TryParse(Console.ReadLine(), out double temperatura))
        {

            if (temperatura <= 1)
            {
                Console.WriteLine("Muito frio");
            }
            else if (temperatura > 20)
               
            {
                Console.WriteLine("Calor");
            }
            else
            {
                Console.WriteLine("Morno");
                

            }
        }
        else
        {
           
            Console.WriteLine("Por favor, insira uma temperatura válida.");
        }

        
        Console.ResetColor();
        Console.ReadKey();
    }
}
