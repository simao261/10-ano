using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foguetao
{
    internal class Foguetao
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Cor { get; set; }

        public Foguetao(int x, int y, ConsoleColor cor)
        {
            X = x;
            Y = y;
            Cor = cor;
        }

        public void Desenhar()
        {
            ConsoleColor corAntiga = Console.ForegroundColor;

            Console.ForegroundColor = Cor;
            Console.SetCursorPosition(X, Y);
            Console.Write("       !");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write("       !");
            Console.SetCursorPosition(X, Y + 2);
            Console.Write("       ^");
            Console.SetCursorPosition(X, Y + 3);
            Console.Write("      / \\");
            Console.SetCursorPosition(X, Y + 4);
            Console.Write("     /___\\");
            Console.SetCursorPosition(X, Y + 5);
            Console.Write("    |=   =|");
            Console.SetCursorPosition(X, Y + 6);
            Console.Write("    |     |");
            Console.SetCursorPosition(X, Y + 7);
            Console.Write("    |     |");
            Console.SetCursorPosition(X, Y + 8);
            Console.Write("    |     |");
            Console.SetCursorPosition(X, Y + 9);
            Console.Write("    |     |");
            Console.SetCursorPosition(X, Y + 10);
            Console.Write("    |     |");
            Console.SetCursorPosition(X, Y + 11);
            Console.Write("    |     |");
            Console.SetCursorPosition(X, Y + 12);
            Console.Write("    |     |");
            Console.SetCursorPosition(X, Y + 13);
            Console.Write("   /|##!##|\\");
            Console.SetCursorPosition(X, Y + 14);
            Console.Write("  / |##!##| \\");
            Console.SetCursorPosition(X, Y + 15);
            Console.Write(" /  |##!##|  \\");
            Console.SetCursorPosition(X, Y + 16);
            Console.Write("|  / ^ | ^ \\  |");
            Console.SetCursorPosition(X, Y + 17);
            Console.Write("| /  ( | )  \\ |");
            Console.SetCursorPosition(X, Y + 18);
            Console.Write("|/  (( | ))  \\|");

            Console.ForegroundColor = corAntiga;
        }

    }
}
