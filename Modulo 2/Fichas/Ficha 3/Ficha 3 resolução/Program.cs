using System;
using System.Data.SqlTypes;

namespace Ficha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Grupo I */

            #region "Exercicio 1"
            /* Exercício 1 */
            /*int a;

            Console.Write("Insira um número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (a < 0)
            {
                Console.WriteLine("O número é negativo");
            }
            else
            {
                Console.WriteLine("O número é positivo");
            }*/
            #endregion

            #region "Exercicio 2"
            /* Exercício 2 */
            /*double teste1, teste2, media;

            Console.Write("Insira a classificação do 1º teste: ");
            teste1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a classificação do 2º teste: ");
            teste2 = Convert.ToDouble(Console.ReadLine());

            media = (teste1 + teste2) / 2;

            Console.WriteLine();
            Console.WriteLine($"Média = {media} valores");

            if (media < 10)
            {
                Console.WriteLine("Não aprovado");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }*/
            #endregion

            #region "Exercicio 3"
            /* Exercício 3 */
            /*string s;
            int a;

            Console.Write("Insira um número: ");
            s = Console.ReadLine();

            Console.WriteLine();

            if (Int32.TryParse(s, out a))
            {
                if (a < 0)
                {
                    Console.WriteLine("O número é negativo");
                }
                else
                {
                    Console.WriteLine("O número é positivo");
                }
            }
            else
            {
                Console.WriteLine("Não introduziu um número inteiro válido");
            }*/
            #endregion

            #region "Exercicio 4"
            /* Exercício 4 */
            /*double teste1, teste2, media;

            Console.Write("Insira a classificação do 1º teste: ");

            if (double.TryParse(Console.ReadLine(), out teste1))
            {
                Console.Write("Insira a classificação do 2º teste: ");

                if (double.TryParse(Console.ReadLine(), out teste2))
                {
                    media = (teste1 + teste2) / 2;

                    Console.WriteLine();
                    Console.WriteLine($"Média = {media} valores");

                    if (media < 10)
                    {
                        Console.WriteLine("Não aprovado");
                    }
                    else
                    {
                        Console.WriteLine("Aprovado");
                    }
                }
                else
                {
                    Console.WriteLine("\nNão introduziu um número válido");
                }
            }
            else
            {
                Console.WriteLine("\nNão introduziu um número válido");
            }*/
            #endregion

            #region "Exercicio 5"
            /* Exercício 5 - Sem TryParse() */
            /*int numero1;
            int numero2;

            Console.Write("Insira o 1º número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Insira o 2º número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"O número {numero1} é o maior");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O número {numero2} é o maior");
            }
            else
            {
                Console.WriteLine("Os números introduzidos são iguais");
            }*/

            /* Exercício 5 - Com TryParse() */
            /*int numero1;
            int numero2;

            Console.Write("Insira o 1º número: ");

            if (int.TryParse(Console.ReadLine(), out numero1))
            {
                Console.Write("Insira o 2º número: ");

                if (int.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.WriteLine();

                    if (numero1 > numero2)
                    {
                        Console.WriteLine("O número {0} é o maior", numero1);
                    }
                    else if (numero2 > numero1)
                    {
                        Console.WriteLine("O número {0} é o maior", numero2);
                    }
                    else
                    {
                        Console.WriteLine("Os números introduzidos são iguais");
                    }
                }
                else
                {
                    Console.WriteLine("\nNão introduziu um número válido");
                }
            }
            else
            {
                Console.WriteLine("\nNão introduziu um número válido");
            }*/
            #endregion

            #region "Exercicio 6"
            /* Exercício 6 - Sem TryParse() */
            /*int numero1;
            int numero2;
            int numero3;

            Console.Write("Insira o 1º número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Insira o 2º número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o 3º número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            if ((numero1 > numero2) && (numero1 > numero3))
            {
                Console.WriteLine($"O número {numero1} é o maior");
            }
            else if ((numero2 > numero1) && (numero2 > numero3))
            {
                Console.WriteLine($"O número {numero2} é o maior");
            }
            else if ((numero3 > numero1) && (numero3 > numero2))
            {
                Console.WriteLine($"O número {numero3} é o maior");
            }
            else
            {
                Console.WriteLine("Os números introduzidos são iguais");
            }
            */

            /* Exercício 6 - Com TryParse() */
            /*
            int numero1, numero2, numero3;

            Console.Write("Insira o 1º número: ");

            if (int.TryParse(Console.ReadLine(), out numero1))
            {
                Console.Write("Insira o 2º número: ");

                if (int.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.Write("Insira o 3º número: ");

                    if (int.TryParse(Console.ReadLine(), out numero3))
                    {
                        Console.WriteLine();

                        if ((numero1 > numero2) && (numero1 > numero3))
                        {
                            Console.WriteLine($"O número {numero1} é o maior");
                        }
                        else if ((numero2 > numero1) && (numero2 > numero3))
                        {
                            Console.WriteLine($"O número {numero2} é o maior");
                        }
                        else if ((numero3 > numero1) && (numero3 > numero2))
                        {
                            Console.WriteLine($"O número {numero3} é o maior");
                        }
                        else
                        {
                            Console.WriteLine("Os números introduzidos são iguais");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNão introduziu um número válido");
                    }
                }
                else
                {
                    Console.WriteLine("\nNão introduziu um número válido");
                }
            }
            else
            {
                Console.WriteLine("\nNão introduziu um número válido");
            }
            */
            #endregion

            /* Grupo II */

            #region "Exercicio 1"
            /* Exercício 1 - Sem TryParse() */
            /*int mes;

            Console.Write("Insira um número: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if ((mes >= 1) && (mes <= 12))
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Mês: janeiro");
                        break;
                    case 2:
                        Console.WriteLine("Mês: fevereiro");
                        break;
                    case 3:
                        Console.WriteLine("Mês: março");
                        break;
                    case 4:
                        Console.WriteLine("Mês: abril");
                        break;
                    case 5:
                        Console.WriteLine("Mês: maio");
                        break;
                    case 6:
                        Console.WriteLine("Mês: junho");
                        break;
                    case 7:
                        Console.WriteLine("Mês: julho");
                        break;
                    case 8:
                        Console.WriteLine("Mês: agosto");
                        break;
                    case 9:
                        Console.WriteLine("Mês: setembro");
                        break;
                    case 10:
                        Console.WriteLine("Mês: outubro");
                        break;
                    case 11:
                        Console.WriteLine("Mês: novembro");
                        break;
                    case 12:
                        Console.WriteLine("Mês: dezembro");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Não introduziu um mês válido");
            }*/

            /* Exercício 1 - Com TryParse() */
            /*int mes;

            Console.Write("Insira um número: ");

            if (Int32.TryParse(Console.ReadLine(), out mes))
            {
                Console.WriteLine();

                if ((mes >= 1) && (mes <= 12))
                {
                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("Mês: janeiro");
                            break;
                        case 2:
                            Console.WriteLine("Mês: fevereiro");
                            break;
                        case 3:
                            Console.WriteLine("Mês: março");
                            break;
                        case 4:
                            Console.WriteLine("Mês: abril");
                            break;
                        case 5:
                            Console.WriteLine("Mês: maio");
                            break;
                        case 6:
                            Console.WriteLine("Mês: junho");
                            break;
                        case 7:
                            Console.WriteLine("Mês: julho");
                            break;
                        case 8:
                            Console.WriteLine("Mês: agosto");
                            break;
                        case 9:
                            Console.WriteLine("Mês: setembro");
                            break;
                        case 10:
                            Console.WriteLine("Mês: outubro");
                            break;
                        case 11:
                            Console.WriteLine("Mês: novembro");
                            break;
                        case 12:
                            Console.WriteLine("Mês: dezembro");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Não introduziu um mês válido");
                }
            }
            else
            {
                Console.WriteLine("\nNão introduziu um número inteiro válido");
            }*/
            #endregion

            #region "Exercicio 2"
            /* Exercício 2 - Sem TryParse() */
            /*int numero1, numero2;
            string operacao;

            Console.Write("Insira o 1º número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o 2º número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a operação a efetuar: ");
            operacao = Console.ReadLine();

            Console.WriteLine();

            switch (operacao)
            {
                case "+":
                    Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                    break;
                case "-":
                    Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                    break;
                case "*":
                    Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
                    break;
                case "/":
                    Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                    break;
                case "%":
                    Console.WriteLine($"{numero1} % {numero2} = {numero1 % numero2}");
                    break;
            }*/

            /* Exercício 2 - Com TryParse() */
            /*int numero1, numero2;
            string operacao;

            Console.Write("Insira o 1º número: ");
            Int32.TryParse(Console.ReadLine(), out numero1);

            Console.Write("Insira o 2º número: ");
            Int32.TryParse(Console.ReadLine(), out numero2);

            Console.Write("Insira a operação a efetuar: ");
            operacao = Console.ReadLine();

            Console.WriteLine();

            switch (operacao)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", numero1, numero2, numero1 + numero2);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", numero1, numero2, numero1 - numero2);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", numero1, numero2, numero1 * numero2);
                    break;
                case "/":
                    Console.WriteLine("{0} / {1} = {2}", numero1, numero2, numero1 / numero2);
                    break;
                case "%":
                    Console.WriteLine("{0} % {1} = {2}", numero1, numero2, numero1 % numero2);
                    break;
            }
            */
            #endregion

            Console.ReadKey();

        }
    }
}
