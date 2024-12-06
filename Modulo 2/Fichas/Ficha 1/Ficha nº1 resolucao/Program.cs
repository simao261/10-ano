using System;
namespace Ficha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            Console.WriteLine("Hello world\nOlá mundo");
            // Exercício 2
            Console.WriteLine();
            Console.WriteLine("Olá");
            Console.WriteLine();
            Console.Write("O meu nome é ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("João");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Número: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("99");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Turma e curso: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("10o PSI");
            // Exercício 3
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("**********");
            Console.WriteLine("* *");
            Console.WriteLine("* *");
            Console.WriteLine("**********");
            // Exercício 4
            Console.WriteLine();
            Console.WriteLine(" *");
            Console.WriteLine(" **");
            Console.WriteLine(" ***");
            Console.WriteLine(" ****");
            Console.WriteLine(" *****");
            Console.WriteLine(" ******");
            Console.WriteLine(" *******");
            Console.WriteLine("********");
            // Exercício 5
            Console.WriteLine();
            Console.Write("A linguagem ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("C#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" foi desenvolvida pela ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Microsoft");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(".");
            // Exercício 6
            Console.WriteLine();
            Console.WriteLine(" *");
            Console.WriteLine(" ***");
            Console.WriteLine(" *****");
            Console.WriteLine("*******");
            Console.WriteLine(" |");
            // Exercício 7
            Console.WriteLine();
            Console.WriteLine(2 + 2);
            Console.ReadKey();
        }
    }
}