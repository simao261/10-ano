// Fixha 1

// ex a


//string x = "O rato roeu a rolha...";
//string y = "...da garrafa do rei da Rússia";

//Console.WriteLine($"A string x tem {x.Length} caracteres");
//Console.ReadKey();

// ex b

//if (x.Contains("rolha")) ;
//Console.WriteLine(" a string x contem a palavra \"rolha\"");
//if (y.Contains("rolha")) ;
//Console.WriteLine("a string y contem a palavra \"rolha\"");
//Console.ReadKey();

// ex c

//Console.WriteLine(x.IndexOf("roeu"));
//Console.ReadKey();

// ex D

//Console.WriteLine(y.LastIndexOf("i"));
//console.readkey();

// ex e

//string x2 = "Análise da frase ''";
//x2 = x2.Insert(18, x);
//Console.WriteLine($" string x2: {x2} ");

//Console.ReadKey();

// ex f

//string z = x.Replace(" ", "_" );
//Console.WriteLine(z);
//Console.ReadKey();

// metedo replace

//x = x.Replace("0", "a").Replace("a", "o");
//Console.WriteLine(x);
//Console.ReadKey();

// metedo substring

//string email;

//Console.WriteLine("insira o seu email:");

//email = Console.ReadLine();

//email.Substring(5);

//Console.ReadKey();


// metedo indeoof

//string email;

//int i;

//Console.WriteLine("insira o seu email: ");

//email = Console.ReadLine();

//i = email.IndexOf("@");

//Console.WriteLine(email.Substring(0, i));

//Console.ReadKey();

// grupo 2

// ex 2

//string Nome;


//Console.Write(" Nome: ");
//string nome = Console.ReadLine();

//int i = nome.IndexOf(" ") + 1;
//int j = nome.LastIndexOf(" ") + 1;

//string s = nome.Substring(0, i);
//string o = nome.Substring(j);

//Console.WriteLine($"Primeiro nome: {s}");
//Console.WriteLine($"Ultimo nome: {o}");

//Console.ReadKey();

// ex 7

//string username = "darth_vader", password = "12345";



//Console.Write("Insira o username: ");
//string username2 = Console.ReadLine();

//Console.Write("Insira a password: ");
//string passoword2 = Console.ReadLine();

//if (username == username2  && password == passoword2)  

//    Console.WriteLine("Acesso concedido: introduziu os dados corretos");
//else

//Console.WriteLine("Acesso negado: username e/ou password incorretos!");

//Console.ReadKey();

// grupo 3

// ex 1


//String texto = " C# is a general-purpose, multi-paradigm programming language encompassing strong typing,\nlexically scoped, imperative, declarative, functional, generic, object-oriented (class-based), and\ncomponent-oriented programming disciplines. It was developed around 2000 by Microsoft as\npart of its .NET initiative, and later approved as an international standard by Ecma (ECMA-334)\nand ISO (ISO/IEC 23270:2018). Mono is the name of the free and open-source project to develop\na compiler and runtime for the language. C# is one of the programming languages designed for\nthe Common Language Infrastructure (CLI).\nC# was designed by Anders Hejlsberg, and its development team is currently led by Mads\nTorgersen. The most recent version is 8.0, which was released in 2019 alongside Visual Studio\n2019 version 16.3.";

//texto = texto.ToLower().Replace(";", "").Replace(" ", "\n").Replace(".", "");
//Console.WriteLine(texto);

//Console.ReadKey();

//Console.Write(" Nome: ");
//string nome = Console.ReadLine();

//int i = nome.IndexOf(" ") + 1;
//int j = nome.LastIndexOf(" ") + 1;

//string s = nome.Substring(0, i);
//string o = nome.Substring(j);

//Console.WriteLine($" Primeiro nome: {s} ");
//Console.WriteLine($" ultimo nome: {o} ");

//Console.ReadKey();


