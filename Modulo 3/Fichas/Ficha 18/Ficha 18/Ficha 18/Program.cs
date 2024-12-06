// ex 1.1

float peso, altura, IMC;

Console.WriteLine("Insira a altura (Metros)");
altura = float.Parse(Console.ReadLine());
Console.WriteLine("Insira o peso (Kg)");
peso = float.Parse(Console.ReadLine());

IMC = peso / (altura * altura);

Console.WriteLine("IMC= " + IMC);

if (IMC <= 18.5)
{
    Console.WriteLine("Baixo Peso ");
}
else if (IMC <= 24.9)
{
    Console.WriteLine("Peso Normal ");
}
else if (IMC <= 29.9)
{
    Console.WriteLine("Pré-Obesidade ");
}

else if (IMC <= 34.9)
{
    Console.WriteLine("Obesidade Grau I ");
}

else if (IMC <= 39.9)
{
    Console.WriteLine("Obesidade Grau II ");
}


else
    Console.WriteLine("Obesidade Grau III ");

Console.ReadKey();

// ex 1.2

Console.WriteLine("insira o volume de vendas do vendedor");
int VolumedeVendas = Convert.ToInt32(Console.ReadLine());

if (VolumedeVendas <= 3000)
{
    Console.WriteLine("Fraco Vendedor");
}

else if (VolumedeVendas >= 3001 && VolumedeVendas <= 4500)
{
    Console.WriteLine("Vendedor Médio");
}

else if (VolumedeVendas >= 4501 && VolumedeVendas <= 7000)
{
    Console.WriteLine("Bom Vendedor");
}

else
{
    Console.WriteLine("Ótimo Vendedor");
}

Console.ReadKey();

// ex 1.3

int num1, num2, num3, menor, maior, meio;

Console.WriteLine("Insira o primeiro valor inteiro");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo valor inteiro");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o terceiro valor inteiro");
num3 = int.Parse(Console.ReadLine());


if ((num1 < num2) & (num1 < num3))
{
    menor = num1;
}
else
{
    if ((num2 < num1) & (num2 < num3))
    {
        menor = num2;
    }
    else
    {
        menor = num3;
    }
}


if ((num1 > num2) & (num1 > num3))
{
    maior = num1;
}
else
{
    if ((num2 > num1) & (num2 > num3))
    {
        maior = num2;
    }
    else
    {
        maior = num3;
    }
}


if (((num1 > num2) & (num1 < num3)) || ((num1 > num3) & (num1 < num2)))
{
    meio = num1;
}
else
{
    if (((num2 > num1) & (num2 < num3)) || ((num2 > num3) & (num2 < num1)))
    {
        meio = num2;
    }
    else
    {
        meio = num3;
    }
}
Console.WriteLine(menor + "," + meio + "," + maior);

// 1.4

Console.WriteLine("insira o seu Salário Bruto");
double SalarioBruto = Convert.ToDouble(Console.ReadLine());

double imposto = 0;

if (SalarioBruto < 1000)
{
    imposto = SalarioBruto * 0.05;
}

else if (SalarioBruto >= 1000 && SalarioBruto < 5000)
{
    imposto = SalarioBruto * 0.11;
}

else
{
    imposto = SalarioBruto * 0.35;
}

double salarioliquido = SalarioBruto - imposto;

Console.WriteLine($"O salário líquido é: {salarioliquido}€");
Console.WriteLine($"O imposto a pagar é: {imposto}€");

Console.ReadKey();

// ex 1.6

Console.WriteLine("insira uma hora do dia");
int hora = Convert.ToInt32(Console.ReadLine());

if (hora >= 5 && hora < 8)
{
    Console.WriteLine("Madrugada");
}

else if (hora >= 8 && hora < 13)
{
    Console.WriteLine("Manha");
}

else if (hora >= 13 && hora < 19)
{
    Console.WriteLine("Tarde");
}

else
{
    Console.WriteLine("Noite");
}
Console.ReadKey();

// 1.7

Console.WriteLine("Insira o 1ªLado");
int lado1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o 2ªLado");
int lado2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o 2ªLado");
int lado3 = Convert.ToInt32(Console.ReadLine());

if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
{
    Console.WriteLine("triângulo escaleno");
}

else if (lado1 == lado2 && lado2 != lado3 && lado1 != lado3)
{
    Console.WriteLine("triângulo isósceles");
}

else if (lado1 == lado2 && lado2 == lado3 && lado1 == lado3)
{
    Console.WriteLine("triângulo equilátero");
}

else if (lado1 + lado2 < lado3 || lado3 <= 0)
{
    Console.WriteLine("Não é um triângulo");
}

Console.ReadKey();

// 1.4 e 1.5


//int num = 0;

//while (num >= 0)
//{
//    Console.WriteLine("insira um numero");
//    num = int.Parse(Console.ReadLine());


//    int i = 0;
//    float media, numero = 0, soma = 0;

//    while (num >= 0)
//    {
//        Console.WriteLine("Insira um numero: ");
//        numero = float.Parse(Console.ReadLine());
//        i++;
//        if (num >= 0)
//        {
//            soma = soma + num;
//        }
//        media = soma / (i - 1);
//        Console.WriteLine("Inseriu um numero negativo");
//        Console.WriteLine("Inseriu anteriormente " + (i - 1) + " números positivos");
//        Console.WriteLine("A soma de todos os numeros positivos é: " + soma);
//        Console.WriteLine("A média dos valores positivos é: " + media);
//        Console.ReadKey(true);

//    }
//}
//Console.ReadKey();

Console.ReadKey();





