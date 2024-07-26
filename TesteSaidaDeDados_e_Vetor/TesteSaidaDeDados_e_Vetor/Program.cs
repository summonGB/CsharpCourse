using System.Runtime.Intrinsics;

internal class Program
{
    private static void Main(string[] args)
    {
        string UM, DOIS, TRES;
        Console.WriteLine("TESTE DE ENTRADA DE DADOS E VETOR");

        Console.WriteLine("Digite tres palavras com espaço entre elas");
        string[] vet = Console.ReadLine().Split(' ');
        UM = vet[0];
        DOIS = vet[1];
        TRES = vet[2];

        Console.WriteLine(UM);
        Console.WriteLine(DOIS);
        Console.WriteLine(TRES);
    }
}