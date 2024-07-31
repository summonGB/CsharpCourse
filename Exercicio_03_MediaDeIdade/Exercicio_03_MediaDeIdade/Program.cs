using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        string nome1, nome2;
        int idade1, idade2;
        double media;

        string[] vet;
        Console.Write("Digite seu nome e idade respectivamente : ");
        vet = Console.ReadLine().Split(' ');
        nome1 = vet[0];
        idade1 = int.Parse(vet[1]);

        string[] vet2;
        Console.Write("Digite seu nome e idade respectivamente : ");
        vet2 = Console.ReadLine().Split(' ');
        nome2 = vet2[0];
        idade2 = int.Parse(vet2[1]);

        media = (double) (idade1 + idade2) / 2;

        Console.WriteLine("A media entre as duas idade é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " Anos");


    }
}