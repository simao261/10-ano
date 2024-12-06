char[,] jogodogalo = new char[3, 3];


for (int i = 0; i < jogodogalo.GetLength(0); i++)
{
    for ( int j = 0; j < jogodogalo.GetLength(1); j++)
    {
        jogodogalo[i, j] = '_';
    }
}

for (int i = 0; i < jogodogalo.GetLength(0); i++)
{
    for (int j = 0; j < jogodogalo.GetLength(1); j++)
    {
        if (j == jogodogalo.GetLength(1) -1)

        {

        }
        Console.Write("| "+jogodogalo[i, j]+ " |");
    }
    Console.WriteLine("_________");
    
}


Console.ReadKey();

