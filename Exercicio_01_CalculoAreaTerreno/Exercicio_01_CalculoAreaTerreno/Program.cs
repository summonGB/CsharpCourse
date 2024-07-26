using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        double comp, larg, area, preco, areaF, precoF;

        
        Console.WriteLine("CALCULADORA DE AREA E PREÇO DE LOTEAMENTO");

        // Comprimento
        Console.WriteLine("Digite o comprimento do seu Terreno:");
        comp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Largura
        Console.WriteLine("Agora Digite a Largura do seu Terreno:");
        larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Valor
        Console.WriteLine("Agora por favor, insira o valor por M² que a imobiliaria está cobrando atualmente:");
        preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Formulas/Calculos
        areaF = comp * larg;
        precoF = areaF * preco;

        Console.WriteLine("A area total do seu terreno é " +  areaF.ToString("F2", CultureInfo.InvariantCulture) + " M² ");
        Console.WriteLine("Preço final para compra R$ " + precoF.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine();
        Console.WriteLine("OBRIGADO POR UTILIZAR A FERRAMENTA DE CALCULO DE LOTEAMENTO VOLTE SEMPRE");

    }
}