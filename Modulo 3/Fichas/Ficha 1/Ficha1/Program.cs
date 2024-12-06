using System;

namespace Ficha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testar a classe Aritmetica
            Console.WriteLine($"2 + 10 = {Aritmetica.Soma(2, 10)}");
            /*Console.WriteLine($"2 - 10 = {Aritmetica.Subtracao(2, 10)}");
            Console.WriteLine($"2 * 10 = {Aritmetica.Multiplicacao(2, 10)}");
            Console.WriteLine($"2 / 10 = {Aritmetica.Divisao(2, 10)}");
            Console.WriteLine($"2 / 0 = {Aritmetica.Divisao(2, 0)}");
            Console.WriteLine($"10 % 2 = {Aritmetica.Resto(10, 2)}");
            Console.WriteLine($"10 % 0 = {Aritmetica.Resto(10, 0)}");
            Console.WriteLine();
            Console.WriteLine($"10^2 = {Aritmetica.Quadrado(10)}");
            Console.WriteLine($"10^3 = {Aritmetica.Cubo(10)}");*/

            // Testar a classe Conversoes
            Console.WriteLine();

            /*Console.WriteLine($"36º Celsius = {Conversoes.ConversaoTemperatura(1, 36)}º Fahrenheit");
            Console.WriteLine($"100º Fahrenheit = {Conversoes.ConversaoTemperatura(2, 100)}º Celsius");*/

            Console.ReadKey();
        }
    }
}
