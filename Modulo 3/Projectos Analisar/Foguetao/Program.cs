using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foguetao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Foguetão";

            //Foguetao f1 = new Foguetao(10, 10, ConsoleColor.Green);
            //Foguetao f2 = new Foguetao(30, 4, ConsoleColor.White);

            //f1.Desenhar();
            //f2.Desenhar();

            Console.WriteLine("       !");
            Console.WriteLine("       !");
            Console.WriteLine("       ^");
            Console.WriteLine("      / \\");
            Console.WriteLine("     /___\\");
            Console.WriteLine("    |=   =|");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("   /|##!##|\\");
            Console.WriteLine("  / |##!##| \\");
            Console.WriteLine(" /  |##!##|  \\");
            Console.WriteLine("|  / ^ | ^ \\  |");
            Console.WriteLine("| /  ( | )  \\ |");
            Console.WriteLine("|/  (( | ))  \\|");

            Console.ReadKey();
        }
    }
}
