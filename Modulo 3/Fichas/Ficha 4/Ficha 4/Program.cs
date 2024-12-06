using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ficha_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eercicio 1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 1: ");
            Console.ResetColor();
            CalcularMatriculasAlunos();
            Console.WriteLine();
            // Exercico 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercico 2: ");
            Console.ResetColor();
            Console.WriteLine("Insira um Caracter: ");
            char caracter;
            Lercaracter(out caracter);
            VerificacaoTipo(caracter);
            Console.WriteLine();
            //Exercicio 3 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 3: ");
            Console.ResetColor();
            Console.Write("insira um caractere: ");
            char caractere;
            Lercaractere(out caractere);
            VerificacaoTipocaracter(caractere);
            Console.WriteLine();
            // Exercicio 4
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercico 4: ");
            Console.ResetColor();
            Console.WriteLine("insira o Primeiro numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = Somadosnumeros(numero1, numero2);
            Console.WriteLine("A soma dos numeros " + numero1 + " e " + numero2 + " é igual a: " + resultado);
            Console.WriteLine();
            // Exercicio 5
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 5: ");
            Console.ResetColor();
            Console.WriteLine("Insira o primeiro Numero: ");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo Numero: ");
            double num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro Numero: ");
            double num3 = int.Parse(Console.ReadLine());
            double Maiornumeroo = Maiornumero(num1, num2, num3);
            Console.WriteLine("O maior valor é: " + Maiornumeroo);
            Console.WriteLine();

            // Exercicio 6
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 6: ");
            Console.ResetColor();
            Console.WriteLine("insira o Primeiro Numero: ");
            Console.ResetColor();
            double numeroo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo Numero: ");
            double numeroo2 = int.Parse(Console.ReadLine());
            double Resultado = RaizQuadradaSomadosquadrados(numeroo1, numeroo2);
            Console.WriteLine("O valor da raiz Quadrada da soma dos Quadrados: " + Resultado);
            Console.WriteLine();
            // Exercicio 7
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 7: ");
            Console.ResetColor();
            Console.WriteLine("Insira a Nota F1: ");
            double F1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a nota F2: ");
            double F2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O Aluno passou no Modulo?: " + Nota(F1, F2));
            Console.WriteLine();
            // Exercicio 8
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 8: ");
            Console.ResetColor();
            Console.WriteLine("insira o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Valoresdivisiveis(valor1, valor2);
            Console.WriteLine("os numeros " + valor1 + " e " + valor2 + " sao divisiveis: " + Valoresdivisiveis(valor1, valor2));
            Console.WriteLine();
            // Exercicio 9 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 9: ");
            Console.ResetColor();
            Console.WriteLine("insira um numero: ");
            int Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma de todos os numeros é: " + somadosnumeros(Numero1));
            Console.WriteLine();
            //Exercicio 10
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 10: ");
            Console.ResetColor();
            Console.WriteLine("insira o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Verificacao(a);
            Console.WriteLine("insira o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o terceiro numero: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("a>b>c?: " + Verificacaonumeros(a, b, c));
            Console.WriteLine();
            Console.ReadKey();
            // Exercicio 11
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 11: ");
            Console.ResetColor();
            Console.WriteLine("Insira um numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero: " + numero + " é primo? " + Numeroprimo(numero));
            Console.WriteLine();
            // Exercicio 12
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exercicio 12: ");
            Console.ResetColor();
            int d1, d2, d3;
            Console.WriteLine("Insira o ano : ");
            d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o mês : ");
            d2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o dia : ");
            d3 = int.Parse(Console.ReadLine());
            Console.WriteLine(validar(d1, d2, d3));
            Console.WriteLine("A Data inserida é valida: " + validar(d1, d2, d3));
            Console.ReadKey(true);
            Console.WriteLine();
            //Exercicio 13

            Console.WriteLine("diga um numero inteiro");
            int Num = int.Parse(Console.ReadLine());
            bool primo = false;

            
            
            while (primo != true)
            {
                primo = e_primo(Num);
                if (primo == true)
                {
                    Console.WriteLine(Num);
                }
                else
                {
                    Num = Num - 1;
                }
            }
        }







        // Exercicio 1 
        static void CalcularMatriculasAlunos()
        {
            decimal[] alturas = new decimal[10];
            decimal[] matriculas = new decimal[10];

            int MatriculaMaisAlta = 0;
            int MatriculaMaisBaixa = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"insira a altura do aluno {i + 1}: ");
                alturas[i] = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Insira a matricula do aluno {i + 1}: ");
                matriculas[i] = decimal.Parse(Console.ReadLine());

                if (matriculas[i] < matriculas[MatriculaMaisBaixa])
                {
                    MatriculaMaisBaixa = i;
                }
                if (matriculas[i] > matriculas[MatriculaMaisAlta])
                {
                    MatriculaMaisAlta = i;
                }
            }

            Console.WriteLine($"A matrícula do aluno mais alta é: {matriculas[MatriculaMaisAlta]}");
            Console.WriteLine($"A matrícula do aluno mais baixa é: {matriculas[MatriculaMaisBaixa]}");
        }





        // Exerccio 2
        static void Lercaracter(out char caracter)
        {
            caracter = Console.ReadKey().KeyChar;

        }
        static void VerificacaoTipo(char caracter)
        {
            if (char.IsLetter(caracter))
            {
                Console.WriteLine("\nO caracter introduzido e uma letra!");
            }
            else if (char.IsDigit(caracter))
            {
                Console.WriteLine("\no caracter introduzido e um numero!");
            }
            else
            {
                Console.WriteLine("\n0 caracter introduzido nao e uma letra nem um numero");
            }
        }
        // Exercicio 3 
        static void Lercaractere(out char caractere)
        {
            caractere = Console.ReadKey().KeyChar;
        }
        static void VerificacaoTipocaracter(char caractere)
        {
            if (char.IsLetter(caractere))
            {
                if ("aeiouAEIOU".Contains(caractere))
                {
                    Console.WriteLine("\nO caractere introduzido é uma vogal");

                }
                else
                {
                    Console.WriteLine("\nO caractere introduzido é uma Consoante");
                }
            }
            else
            {
                Console.WriteLine("\nO caractere introduzido não e nenhuma letra");
            }


        }
        // Exetcicio 4 

        static int Somadosnumeros(int numero1, int numero2)
        {
            if (numero1 + numero2 == 0)
            {
                return 0;
            }
            else
            {
                return numero1 + numero2;
            }
        }

        // Exercicio 5 
        static double Maiornumero(double num1, double num2, double num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }

        // Exercicio 6

        static double RaizQuadradaSomadosquadrados(double numeroo1, double numeroo2)
        {

            double somaQuadrados = Math.Pow(numeroo1, 2) + Math.Pow(numeroo2, 2);
            double raizSoma = Math.Sqrt(somaQuadrados);
            return raizSoma;
        }

        // Exercicio 7

        static bool Nota(double F1, double F2)
        {
            int soma = 0;
            if (F1 > 7 && F2 > 7 && F1 + F2 >= 19)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Exercicio 8

        static bool Valoresdivisiveis(int valor1, int valor2)
        {
            if (valor1 % valor2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Exercicio 9 

        static int somadosnumeros(int numero1)
        {

            int soma = 0;
            for (int i = 1; i <= numero1; i++)
            {
                soma += i;


            }
            {
                return soma;
            }

        }

        //Exercicio 10

        static void Verificacao(int a)
        {
            if (a == 0)
            {

                Console.WriteLine("Pograma encerrado");
                Console.ReadKey(true);
                Environment.Exit(0);

            }

        }
        static bool Verificacaonumeros(int a, int b, int c)
        {

            if (a > b && b > c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Exercicio 11
        static bool Numeroprimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)

                {
                    return false; ;
                }

            }
            return true;

        }

        // Exercicio 12

        static bool validar(int ano, int mes, int dia)

        {
            if ((ano <= 2024) && (ano >= 1900))
            {
                if ((mes <= 12) && (mes >= 1))
                {
                    if ((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12))
                    {
                        if ((dia >= 1) && (dia <= 31))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
                        {
                            if ((dia >= 1) && (dia <= 30))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (mes == 2)
                            {
                                if ((ano % 4 == 0) && (dia >= 1) && (dia <= 29))
                                {
                                    return true;
                                }
                                else
                                {
                                    if ((ano % 4 != 0) && (dia >= 1) && (dia <= 28))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }

                            }
                            else
                            { return false; }
                        }
                    }
                }

                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
        // Ex 13

       
        static bool e_primo(int Num)
        {
            
            if (Num == 0)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < Num; i++)
                {
                    if (Num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }


            

        }

       
        

       


       



    }
}

                                                                                                
    

     



























    
