using System;

namespace Ficha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Exercicio 1"
            // Exercício 1
            /*int i = 1;

            while (i <= 10)
            {
                Console.WriteLine($"14 x {i} = {14 * i}");
                ++i;
            }*/
            #endregion

            #region "Exercicio 2"
            // Exercício 2 - Sem TryParse()
            /*int i = 1;
            int numero;

            Console.Write("Insira um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            while (i <= 10)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                ++i;
            }*/

            // Exercício 2 - Com TryParse()
            /*int i = 1;
            int numero;

            Console.Write("Insira um número inteiro: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine();

                while (i <= 10)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                    ++i;
                }
            }*/
            #endregion

            #region "Exercicio 3"
            /*int i = 1;
            int resultado = 0;

            do
            {
                resultado += i;
                ++i;
            }
            while (i <= 18);

            Console.WriteLine($"Resultado da soma: {resultado}");*/
            #endregion

            #region "Exercicio 4"
            /*int i;

            for (i = -3; i <= 13; ++i)
            {
                Console.Write(i);

                if (i < 13)
                {
                    Console.Write(", ");
                }
            }*/
            #endregion

            #region "Exercicio 5"
            // Exercício 5 - Sem TryParse()
            /*int x;
            int y;            
            string tipo;

            Console.Write("Insira o 1º número: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o 2º número: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = x; i <= y; ++i)
            {
                // Determinar se um número é par ou ímpar
                tipo = ((i % 2) == 0) ? "par" : "ímpar";

                // Determinar se um número é par ou ímpar: resolução alternativa
                //if ((i % 2) == 0)
                //{
                //    tipo = "par";
                //}
                //else
                //{
                //    tipo = "ímpar";
                //}

                Console.WriteLine($"{i} = {tipo}");
            }*/

            // Exercício 5 - Com TryParse()
            /*int i;
            int x;
            int y;            
            string tipo;

            Console.Write("Insira o 1º número: ");

            if (int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Insira o 2º número: ");

                if (int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine();

                    for (i = x; i <= y; ++i)
                    {
                        // Determinar se um número é par ou ímpar
                        tipo = ((i % 2) == 0) ? "par" : "ímpar";

                        // Determinar se um número é par ou ímpar: resolução alternativa
                        //if ((i % 2) == 0)
                        //{
                        //    tipo = "par";
                        //}
                        //else
                        //{
                        //    tipo = "ímpar";
                        //}

                        Console.WriteLine($"{i} = {tipo}");
                    }
                }
            }*/
            #endregion

            #region "Exercicio 6"
            /*int celsius = 15;
            float fahrenheit;

            while (celsius <= 26)
            {
                fahrenheit = 1.8F * celsius + 32F;
                Console.WriteLine($"{celsius}º Celsius = {fahrenheit}º Fahrenheit");
                ++celsius;
            }*/
            #endregion

            #region "Exercicio 7"
            /*int celsius;
            float fahrenheit;

            for (celsius = 15; celsius <= 26; ++celsius)
            {
                fahrenheit = 1.8F * celsius + 32F;
                Console.WriteLine($"{celsius}º Celsius = {fahrenheit}º Fahrenheit");
            }*/
            #endregion

            #region "Exercicio 8"

            // Versão while
            /*int i = 2;
            while (i <= 36)
            {
                if (i == 6)
                {
                    Console.Write("   ");
                }
                Console.WriteLine(i);

                i += 2;
            }*/

            // Versão do...while
            /*int i = 2;
            do
            {
                if (i == 6)
                {
                    Console.Write("   ");
                }
                Console.WriteLine(i);

                i += 2;
            } while (i <= 36);*/

            // Versão for
            /*for (int i = 2; i <= 36; i += 2)
            {
                if (i == 6)
                {
                    Console.Write("   ");
                }
                Console.WriteLine(i);
            }*/

            // Versão for (condensado)
            /*for (int i = 2; i <= 36; i += 2)
            {
                Console.WriteLine("{0}{1}", (i == 6) ? "   " : "", i);
            }*/

            #endregion

            #region "Exercicio 9"
            // Exercício 9 - Sem TryParse()
            /*int linhas;
            int colunas;

            Console.Write("Insira o número de linhas: ");
            linhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o número de colunas: ");
            colunas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int l = 1; l <= linhas; ++l)
            {
                for (int c = 1; c <= colunas; ++c)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            // Exercício 9 - Com TryParse()
            /*int l, c, linhas, colunas;

            Console.Write("Insira o número de linhas: ");

            if (int.TryParse(Console.ReadLine(), out linhas))
            {
                Console.Write("Insira o número de colunas: ");

                if (int.TryParse(Console.ReadLine(), out colunas))
                {
                    Console.WriteLine();

                    for (l = 1; l <= linhas; ++l)
                    {
                        for (c = 1; c <= colunas; ++c)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }*/
            #endregion

            #region "Exercicio 10"
            // Exercício 11 - Sem TryParse()
            /*int linhas;

            Console.Write("Insira o número de linhas: ");
            linhas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int l = 1; l <= linhas; ++l)
            {
                for (int c = 1; c <= l; ++c)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            // Exercício 10 - Com TryParse()
            /*int l, c, linhas;

            Console.Write("Insira o número de linhas: ");

            if (int.TryParse(Console.ReadLine(), out linhas))
            {
                Console.WriteLine();

                for (l = 1; l <= linhas; ++l)
                {
                    for (c = 1; c <= l; ++c)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }*/
            #endregion

            #region "Exercício 11"
            // Exercício 11 - Sem TryParse()
            /*int i = 1;
            int n;

            // Declarar instância da classe Random
            Random rnd = new Random();

            Console.Write("Insira a quantidade de números aleatórios a gerar: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            while (i <= n)
            {
                Console.Write(rnd.Next(1, 46));

                // Apenas mostrar vírgula se não tiver sido atingido o último número
                if (i < n)
                {
                    Console.Write(", ");
                }

                ++i;
            }*/

            // Exercício 11 - Com TryParse()
            /*int n;

            // Declarar instância da classe Random
            Random rnd = new Random();

            Console.Write("Insira a quantidade de números aleatórios a gerar: ");

            if (int.TryParse(Console.ReadLine(), out n))
            {
                int i = 1;

                Console.WriteLine();

                while (i <= n)
                {
                    Console.Write(rnd.Next(1, 45));

                    if (i < n)
                    {
                        Console.Write(", ");
                    }

                    ++i;
                }
            }*/
            #endregion

            #region "Exercício 12"
            /*double f;

            for (int x = 9; x <= 22; ++x)
            {
                f = (x * x) + (2 * x) - Math.Sqrt(55);
                Console.WriteLine($"f({x}) = {f}");
            }*/
            #endregion

            #region "Exercício 13"
            /*int i, k;
            int resultado;

            // a)
            for (i = 0, resultado = 0; i <= 50; ++i)
            {
                resultado += 3 + i; 
                
            }
            Console.WriteLine(resultado);

            // b)
            for (k = 0, resultado = 0; k <= 10; ++k)
            {
                resultado += 5 + (4 * k);

            }
            Console.WriteLine(resultado);

            // c)
            for (i = 3, resultado = 0; i <= 6; ++i)
            {
                resultado += (int)Math.Pow(2, i - 2) - 1;

            }
            Console.WriteLine(resultado);*/
            #endregion

            Console.ReadKey();
        }
    }
}
