// Posicionar e escrever nos cantos, bem como no centro da janela
// da consola.

Console.SetCursorPosition(0, 0);
Console.Write("0");

Console.SetCursorPosition(0, Console.WindowHeight - 1);
Console.Write("0");

Console.SetCursorPosition(Console.WindowWidth - 1, 0);
Console.Write("0");

Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
Console.Write("0");

Console.SetCursorPosition((Console.WindowWidth - 1) / 2, (Console.WindowHeight - 1) / 2);
Console.Write("0");
