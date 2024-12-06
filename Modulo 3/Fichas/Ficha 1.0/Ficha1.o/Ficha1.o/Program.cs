////ex 1
//class Pogram
//{
//    static void Main(string[] args)
//    {

//        asteriscos(5);
//        Console.WriteLine("\n");
//        asteriscos(7);
//        Console.WriteLine("\n");
//        asteriscos(5);
//        Console.WriteLine("\n");
//        asteriscos(3);
//        Console.WriteLine("\n");


//    }
//    static void asteriscos(int x)
//    {
//        int i;
//        for (i = 1; i <= x; i++)
//        {
//            Console.Write("*"-);
//        }
//        Console.WriteLine("\n");
//        Console.ReadKey();
//    }
//}

//ex 2



//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Insira o Primeiro Numero:");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Insira o segundo Numero:");
//        int num2 = int.Parse(Console.ReadLine());

//        int maiorNumero = Math.Max(num1, num2);
//        int menorNumero = Math.Min(num1, num2);

//        int somaPares = 0;

//        for (int i = menorNumero + 1; i < maiorNumero; i++)
//{
//    if (i % 2 == 0)
//    {
//        somaPares += i;
//    }
//}

//Console.WriteLine($"A soma dos números pares entre {menorNumero} e {maiorNumero} é: {somaPares}");
//Console.ReadKey();
//    }
//}

// ex 3


////class Program
////{
////    static void Main(string[] args)
////    {
////        Console.WriteLine("introduza dois números diferentes:");

////        Console.Write("Número 1: ");
////        int num1 = int.Parse(Console.ReadLine());

////        Console.Write("Número 2: ");
////        int num2 = int.Parse(Console.ReadLine());

////        int maior = Maior(num1, num2);
////        int menor = Menor(num1, num2);

////        int somaPares = SomaParesEntre(menor, maior);
////        Console.WriteLine($"A soma dos números pares entre {menor} e {maior} é: {somaPares}");
////        Console.ReadKey();

////    }

////    static int Maior(int a, int b)
////    {
////        if (a > b)
////        {
////            return a;
////        }
////        else
////        {
////            return b;
////        }
////    }

////    static int Menor(int a, int b)
////    {
////        if (a < b)
////        {
////            return a;
////        }
////        else
////        {
////            return b;
////        }
////    }

////    static int SomaParesEntre(int menor, int maior)
////    {
////        int sum = 0;
////        for (int i = menor + 1; i < maior; i++)
////        {
////            if (i % 2 == 0)
////            {
////                sum += i;
////            }
////        }
////        return sum;


////    }


////}

//// ex 4


//class Programm
//{
//    static void Soma0_10()
//    {
//        int soma = 0;
//        int num = 0;
//        while (num <= 10)
//        {
//            soma += num;
//            num++;
//        }
//        Console.WriteLine("A soma dos números de 0 a 10 é: " + soma);
//    }


//    static void SomaPares0_100()
//{
//int soma = 0;
//for (int num = 0; num <= 100; num += 2)
//{
//soma += num;
//}
//Console.WriteLine("A soma dos números pares de 0 a 100 é: " + soma);
//}


//static void MaiorNumero()
//{
//    int maior = int.MinValue;
//    int num;
//    do
//    {
//    Console.Write("Introduza um número inteiro positivo (ou 0 para terminar): ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num > maior)
//    {
//        maior = num;
//    }
//} while (num != 0) ;

//if (maior != int.MinValue)
//{
//    Console.WriteLine("O maior número introduzido é: " + maior);
//}
//else
//{
//    Console.WriteLine("Nenhum número foi introduzido.");
//}
//    }


//    static void AlturaDoDia()
//{
//    Console.Write("Introduza a hora do dia (0 a 23): ");
//    int hora = Convert.ToInt32(Console.ReadLine());

//    if (hora >= 5 && hora <= 7)
//    {
//        Console.WriteLine("A altura do dia é: madrugada");
//    }
//    else if (hora >= 8 && hora <= 12)
//    {
//        Console.WriteLine("A altura do dia é: manhã");
//    }
//    else if (hora >= 13 && hora <= 19)
//    {
//        Console.WriteLine("A altura do dia é: tarde");
//    }
//    else if ((hora >= 20 && hora <= 23) || (hora >= 0 && hora <= 4))
//    {
//        Console.WriteLine("A altura do dia é: noite");
//    }
//        else
//{
//Console.WriteLine("Hora inválida.");
//}
//    }

//    static void Main(string[] args)
//{

//    while (true)
//    {
//        Console.WriteLine("\nMenu:");
//        Console.WriteLine("1- Soma");
//        Console.WriteLine("2- Pares");
//        Console.WriteLine("3- Maior");
//        Console.WriteLine("4- Altura do dia");
//        Console.WriteLine("0 - Sair do Programa");

//        Console.Write("Escolha uma opção: ");
//        string escolha = Console.ReadLine();

//        if (escolha == "1")
//        {
//            Soma0_10();
//            }
//            else if (escolha == "2")
//{
//    SomaPares0_100();
//}
//else if (escolha == "3")
//{
//    MaiorNumero();
//}
//else if (escolha == "4")
//{
//    AlturaDoDia();
//}
//else if (escolha == "0")
//{
//    Console.WriteLine("Programa encerrado.");
//    break;
//}
//else
//{
//    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
//}
//        }
//    }
//}


//// ex 5


//Console.WriteLine("")







































