using System;
namespace QAula1
{
    class Program
    {
        public static double maior_num = 0, menor_num = 0, soma = 0;

        public static void Main(string[] args)
        {
            int i = 0, n;
            double num1 = -1;
            Console.WriteLine("Quantos números pretende inserir? ");
            n = int.Parse(Console.ReadLine());

            while (i < n)
            {
                Console.WriteLine("Insira o numero " + (i + 1));
                num1 = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maior_num = num1;
                    menor_num = num1;
                }
                maior(num1);
                menor(num1);
                somar(num1);
                i++;
            }
            Console.WriteLine("\nForam inseridos " + i + " números.");
            Console.WriteLine("\nO menor número inserido foi o " + menor_num);
            Console.WriteLine("\nO maior número inserido foi o " + maior_num);
            Console.WriteLine("\nA soma de todos os valores é: " + soma);
            Console.WriteLine("\nA média de todos os valores é: " + media(soma, i));
            Console.ReadKey(true);
        }
        static double maior(double val)
        {
            if (val > maior_num)
            {
                maior_num = val;
            }
            return maior_num;
        }


        static double menor(double val)
        {
            if (val < menor_num)
            {
                menor_num = val;
            }
            return menor_num;
        }
        static double somar(double val)
        {
            soma = soma + val;
            return soma;
        }
        static double media(double sum, int j)
        {
            double med = sum / j;
            return med;
        }

    }
}