using System;
using System.ComponentModel;

namespace Ficha_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1.1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exerciico 1.1:");
            Console.ResetColor();
            int a = LerInteiroA("Digite o valor de a (a >= 1): ");
            int b = LerInteiroB("Digite o valor de b (b >= 0): ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"O resultado de {a}^{b} é: {Potencia(a, b)}");
            Console.ResetColor();
            Console.WriteLine();

            // Exercício 1.2
            // 1 forma
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercício 1.2:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("n_segundos(0) --->" + n_segundos(0));
            Console.WriteLine("n_segundos(1) --->" + n_segundos(1));
            Console.WriteLine("n_segundos(2) --->" + n_segundos(2));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadKey();



            // Exercício 1.3
            // 1 forma
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nExercício 1.3: 1 Forma: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Utilizando if-else:");
             Console.WriteLine("num(3, 'h') ---> " + NumIfElse(3, 'h'));
             Console.WriteLine("num(3, 'm') ---> " + NumIfElse(3, 'm'));
             Console.WriteLine("num(3, 's') ---> " + NumIfElse(3, 's'));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nUtilizando switch:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("num(3, 'h') ---> " + NumSwitch(3, 'h'));
             Console.WriteLine("num(3, 'm') ---> " + NumSwitch(3, 'm'));
             Console.WriteLine("num(3, 's') ---> " + NumSwitch(3, 's'));
            Console.ResetColor();
             Console.WriteLine();

            // 2 fornma
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nExercício 1.3: 2 Forma: ");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o tipo ('s' para segundos, 'm' para minutos, 'h' para horas):");
            char tipo = Convert.ToChar(Console.ReadLine());

            long resultado = NumSwitch(numero, tipo);
          
            
            if (resultado != -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(numero + " equivalem a: " + resultado + tipo );
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tipo inválido.");
                Console.ResetColor();
            }
            Console.WriteLine();
            // Exercicio 1.4
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercico 1.4:");
            Console.ResetColor();
            Console.Write("Digite Um numero inteiro: ");
            int Numero = Convert.ToInt32(Console.ReadLine());
            int soma = Calcularsomanumeros(numero);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A soma dos numeros inteiros ate {0} é: {1}", numero, soma);
            Console.ResetColor();
            Console.WriteLine();

            // Exercico 1.5
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercico 1.5:");
            Console.ResetColor();
            Console.Write("Insira o Primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int Resultado = somadosnumeros(numero1, numero2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A soma dos numeros: " + numero1 + " e " + numero2 + " é igual a: " + Resultado);
            Console.ResetColor();
            Console.WriteLine();

            // Exercico 1.6
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 1.6:");
            Console.ResetColor();
            Console.Write("Insira um Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira um mês: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira um dia: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            bool dataValida = DataValida(ano, mes, dia);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A Data é Valida? " + dataValida);
            Console.ResetColor();
            Console.WriteLine();

            //Exercicio 1.7
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 1.7:");
            Console.ResetColor();
            Console.Write("Insira um ano: ");
            int Ano = Convert.ToInt32(Console.ReadLine());
            int anobissexto = Anobixesto(Ano);
            Console.WriteLine();

            // Exercicio 1.8
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 1.8");
            Console.ResetColor();
            char caractere = Lercaracter("Digite um Caracter: ");
            VerificacaoTipo(caractere);

            // Exercicio 1.9
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 1.9: ");
            Console.ResetColor();
            int i, tabuada, result;
            Console.WriteLine("Insira qual a tabuada que deseja visualizar (número inteiro!)");
            tabuada = int.Parse(Console.ReadLine());
            result = 0;
            i = 0;
            for (i = 1; i <= 10; i++)
            {
                multiplic(i, tabuada, ref result);
                Console.WriteLine(tabuada + " x " + i + " = " + result);
            }
            Console.ReadKey(true);
            Console.ReadKey();


        }
        //Exercicio 1.1
        static int LerInteiroA(string mensagem)
        {
            int valor;
            do
            {
                Console.Write(mensagem);
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor < 1);

            return valor;
        }
        static int LerInteiroB(string mensagem)
        {
            int valor;
            do
            {
                Console.Write(mensagem);
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor < 0);

            return valor;
        }
        static long Potencia(int a, int b)
        {
            if (b == 0)
                return 1;
            else
                return a * Potencia(a, b - 1);
        }

        // Exercício 1.2
        static long n_segundos(int n_horas)
        {
            return n_horas * 3600;
        }

        // Exercício 1.3
        static long NumIfElse(int nTempo, char tipo)
        {
            if (tipo == 'h')
            {
                return nTempo;
            }
            else if (tipo == 'm')
            {
                return nTempo * 60;
            }
            else if (tipo == 's')
            {
                return nTempo * 3600;
            }
            return -1;
        }

        static long NumSwitch(int nTempo, char tipo)
        {
            switch (tipo)
            {
                case 'h':
                    return nTempo;
                case 'm':
                    return nTempo * 60;
                case 's':
                    return nTempo * 3600;
                default:
                    return -1;
            }
        }
        // Exercicio 1.4
        static int Calcularsomanumeros(int numero)
        {
            int soma = 0;
            for (int i = 1; i <= numero; i++)
            {
                soma += i;
            }
            return soma;
        }
        // Exercico 1.5
        static int somadosnumeros(int num1, int num2)
        {
            if (num1 + num2 == 0)
            {
                return 0;
            }
            return num1 + num2;

        }
        //Exercicio 1.6
        static bool DataValida(int ano, int mes, int dia)
        {
            if (ano < 1900 || ano > 2024)
            {
                return false;
            }
            if (mes < 1 || mes > 12)
            {
                return false;
            }
            if (dia < 1 || dia > DateTime.DaysInMonth(ano, mes))
            {
                return false;
            }
            return true;




        }
        // ou

        /*static bool DataValida(int ano, int mes, int dia)
        {
            int anoAtual = DateTime.Now.Year;

            if (ano < 1900 || ano > anoAtual)
            {
                return false;
            }

            if (mes < 1 || mes > 12)
            {
                return false;
            }

            if (dia < 1 || dia > DateTime.DaysInMonth(ano, mes))
            {
                return false;
            }

            return true;
        }*/

        //Exercicio 1.7

        static int Anobixesto(int ano)
        {
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este Ano é Bixesto");
                Console.ResetColor();
                return 1;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este Ano Não é Bixesto");
                Console.ResetColor();
                return 0;
            }   

        }
        // Exercicio 1.8
        static char Lercaracter(string Mensagem)
        {
            Console.Write(Mensagem);
            char caractere;
            while (!char.TryParse(Console.ReadLine(), out caractere))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida. Tente novamente.");
                Console.ResetColor();
                Console.Write(Mensagem);
            }
            return caractere;
        }
        static void VerificacaoTipo(char caracter)
        {
            if (char.IsDigit(caracter))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O caractere é um número.");
                Console.ResetColor();
            }
            else if (char.IsLetter(caracter))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O caractere é uma letra.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O caractere não é nem número nem letra.");
                Console.ResetColor();
            }
        }

        // Exercicio 1.9

        static void multiplic(int ind, int tab, ref int result1)
        {
            result1 = ind * tab;
        }

    }    
}