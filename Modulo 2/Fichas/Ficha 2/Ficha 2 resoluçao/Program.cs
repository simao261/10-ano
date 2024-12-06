//1.Resolução:
//a) 14(string)
//b) 10(float), ou 11 (double) ou 12 (decimal)
//c) 3(byte) ou 2 (sbyte)
//d) 14(string)
//e) 6(int), ou 4 (short), ou 5 (ushort), ou qualquer um dos outros tipos inteiros
//f) 12(decimal), ou 10 (float) ou 11 (double)
//g) 14(string)
//h) char

using System.Text;

//2.Resolução:
string morada = "Avenida Fernão de Magalhães";
float temperatura = 27.2F;
byte idade = 33;
string isbn = "978-1401359621";
int anoEdicao = 2003;
decimal precoLivro = 8.49M;
string telefone = "+351 - 239123456";
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Morada: \"{0}\"", morada);
Console.WriteLine("Temperatura: {0}o", temperatura);
Console.WriteLine("Idade: {0} anos", idade);
Console.WriteLine("Código ISBN-13: {0}", isbn);
Console.WriteLine("Ano edição: {0}", anoEdicao);
Console.WriteLine("Preço livro: €{0}", precoLivro);
Console.WriteLine("Número telefone: {0}", telefone);
Console.ReadKey();

//3.Resolução:
//a) True
//b) False
//c) True
//d) True

//4. Resolução:
int a, b, c;
Console.Write("Insira o 1o número: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o 2o número: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o 3o número: ");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nResultado: {0}", (a + b + c));
Console.ReadKey();

//5.Resolução:
int a, b;
Console.Write("Insira o 1o número: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o 2o número: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
Console.WriteLine("{0} / {1} = {2}", a, b, (float)a / (float)b);
Console.WriteLine("média = {0}", (float)(a + b) / 2F);
Console.WriteLine("{0} % {1} = {2}", a, b, a % b);


//6.Resolução:
int m;
float km;
Console.Write("Insira uma distância em metros: ");
m = Convert.ToInt32(Console.ReadLine());
km = m / 1000F;
Console.WriteLine("\nResultado: {0:F2} KM", km);
Console.ReadKey();


//7.Resolução:
double celsius, fahrenheit;
Console.Write("Insira uma temperatura em graus Celsius: ");
celsius = Convert.ToDouble(Console.ReadLine());
fahrenheit = celsius * 1.8D + 32;
Console.WriteLine("\nResultado:\n {0}o C = {1:F1}o F", celsius, fahrenheit);
Console.ReadKey();


//8.Resolução:
int x, z, w;
double y;
Console.Write("x = ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
z = Convert.ToInt32(Console.ReadLine());
Console.Write("w = ");
w = Convert.ToInt32(Console.ReadLine());
y = (double)((z * 200) + (x * x)) / (double)(w - 5);
Console.WriteLine("\nResultado: {0}", y);

//9.Resolução:
int noites;
decimal custo, custoIva;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Cálculo do custo da estadia\n");
Console.Write("Insira o número de noites: ");
noites = Convert.ToInt32(Console.ReadLine());
custo = noites * 35;
custoIva = custo * 1.23M;
Console.WriteLine("\nCusto da estadia (sem IVA) = €{0:F2}", custo);
Console.WriteLine("Custo da estadia (com IVA) = €{0:F2}", custoIva);
Console.ReadKey();


d