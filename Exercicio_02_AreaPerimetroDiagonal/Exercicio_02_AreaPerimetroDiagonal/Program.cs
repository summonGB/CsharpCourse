using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        double Base, Altura, Area, Peri, Diag;

        Console.Write("Digite o tamanho da Base do triangulo : ");
        Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite a Altura do triangulo : ");
        Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Area = Base * Altura;
        Peri = (2 * Base) + (2 * Altura);
        Diag = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(Altura, 2.0));

        Console.WriteLine("AREA = " + Area.ToString("F4",CultureInfo.InvariantCulture ));
        Console.WriteLine("PERIMETRO = " + Peri.ToString("F4",CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + Diag.ToString("F4", CultureInfo.InvariantCulture));



    }
}