Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

int[] idades = { 3, 5, 7};

idades = idades.Append(13).ToArray();
idades = idades.Append('a').ToArray();

foreach (int idade in idades)
{
    Console.WriteLine(idade);
}
