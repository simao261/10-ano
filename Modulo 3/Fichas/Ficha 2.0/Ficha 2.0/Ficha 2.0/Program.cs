
// ex 1.1
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Insira uma temperatura em Fahrenheit: ");
//        double fahrenheit = Convert.ToDouble(Console.ReadLine());

//        double celsius = temperatura(fahrenheit);

//        Console.WriteLine($"A temperatura em Celsius é aproximadamente {celsius} graus.");
//        Console.ReadKey();
//    }

//    static double temperatura(double f)
//    {
//        double celsius;

//        celsius = Math.Round(5 * (f - 32) / 9, 0);
//        return celsius;
//    }

//}


// ex 1.2



//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Insira uma nota: ");
//        int nota = int.Parse(Console.ReadLine());

//        if (ValidaNota(nota))
//        {
//            Console.WriteLine("A nota é válida.");
//        }
//        else
//        {
//            Console.WriteLine("A nota é inválida.");
//        }
//        Console.ReadLine();
//    }

//    static bool ValidaNota(int nota)
//    {
//        return nota >= 0 && nota <= 20;
//    }
//}

// ex 1.3


//class Pogram
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Insira o Primeiro Numero: ");
//        int x = int.Parse(Console.ReadLine());

//        Console.Write("Insira o segundo Numero: ");
//        int y = int.Parse(Console.ReadLine());

//        Console.Write("Insira o terceiro Numero: ");
//        int z = int.Parse(Console.ReadLine());

//        int menornumero = Menor(x, y, z);
//        Console.WriteLine($"O menor Numero é "+ menornumero);

//        Console.ReadKey();
//    }

//    static int Menor ( int x , int y , int z)
//    {
//        if ( x < y && x < z )
//        {
//            return x;
//        }

//        else if ( y < x && y < z )
//        {
//            return y;
//        }

//        else
//        {
//            return z;
//        }
//    }
//}

// ex 1.4
//class Pogram
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Insira Um Numero: ");
//        int n = int.Parse(Console.ReadLine());
//        Diasemana(n);
//        Console.ReadKey();
//    }

//    static void Diasemana( int n)
//    {
//        if (n == 1)
//        {
//            Console.WriteLine("Hoje é Domingo");
//        }
//        else if (n == 2 )
//        {
//            Console.WriteLine("Hoje é Segunda");
//        }
//        else if (n == 3)
//        {
//            Console.WriteLine("Hoje é Terça");
//        }
//        else if (n == 4)
//        {
//            Console.WriteLine("Hoje é Quarta");
//        }
//        else if (n == 5)
//        {
//            Console.WriteLine("Hoje é Quinta");
//        }
//        else if (n == 6)
//        {
//            Console.WriteLine("Hoje é sexta");
//        }
//        else if (n == 7)
//        {
//            Console.WriteLine("Hoje é Sabado");
//        }
//        else
//        {
//            Console.WriteLine("Numero Invalido, Por Favor Insira um numero entre 1 e 7");
//        }

//    }
//}

// ex 1.5



//class Pogram
//{

//    static void Main (string[] args)
//    {
//        Console.Write("Insira uma Vogal: ");
//        char letra = Console.ReadKey().KeyChar;

//        if (eVogal(letra))
//        {
//            Console.WriteLine("\nÉ uma Vogal");
//        }
//        else
//        {
//            Console.WriteLine("\nNão é Uma Vogal");
//        }

//        Console.ReadKey();
//    }

//    static bool eVogal(char c)
//    {
//        c = char.ToLower(c);

//        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
//    }
//}

// 1.6

//class Pogram
//{
//    static void Main(string[] args)
//    {

//        int min = 10;
//        int max = 50;


//        int[] numeros = { 20, 70, 35, 45, 178 };

//        foreach (int num in numeros)
//        {
//            Console.WriteLine($"O número {num} pertence ao intervalo [{min}, {max}]? {PertenceIntervalo(num, min, max)}");
//        }

//        Console.ReadKey();
//    }

//    static bool PertenceIntervalo(int n, int min, int max)
//    {
//        return n >= min && n <= max;
//    }
//}

// ex 1.7



class Pogramm
{
   static void Main(string[] args)
   {
        Console.Write("Introduza a Quantidade de Numeros a serem verificados: ");
        int n = int.Parse(Console.ReadLine());
        int Maior = MaiorValor(n);
       Console.WriteLine($"O Maior Valor é: " + Maior);
       Console.ReadKey();
   }

    static int MaiorValor (int n)
    {

      int maior = 0;
      int i = 0;

        do
        {
            Console.Write("Introduza o " + (i + 1) + "º Numero: ");
            int numero = int.Parse(Console.ReadLine());

           if (numero > maior)
            {
            maior = numero;
            }
            i++;


        } while (i < n);

        return maior;

    }
}

// 2

// 2.1

// string Parametrosentrada =  "Parâmetros de entrada e seus tipos de dados: Parametro n do tipo (int)";

// 2.2

// string Variaveis = "A variável local f é do tipo inteiro (int), utilizada para armazenar o resultado do fatorial.A variável local i é do tipo inteiro (int), utilizada como contador no loop for.";

// 2.2

// string DevolucaodaFuncao = "A função retorna um valor inteiro (int), que é o resultado da conta do número fornecido como entrada."
x






