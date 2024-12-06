
string equipaFutebol = "Académica";

for (int i = equipaFutebol.Length - 1; i >= 0; i--)
{
    Console.Write(equipaFutebol[i]);
}

for (int i = 0; i < equipaFutebol.Length; ++i)

    Console.WriteLine(equipaFutebol[i]);

equipaFutebol.IndexOf("u");

string x = "O aluno passa o tempo a fazer festinhas ao trackpad do seu computador";

x = x.Replace("festinhas ao", "zoom no");

x = x.Replace(' ', '!');

Console.Write(x);

Console.ReadKey();
