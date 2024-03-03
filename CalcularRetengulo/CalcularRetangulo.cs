using System;

public class CalculadoraRetangulo
{
    public static void CalcularArea()
    {
        Console.WriteLine("Digite a largura: ");
        int largura = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura: ");
        int altura = int.Parse(Console.ReadLine());

        double area = largura * altura;

        Console.WriteLine($"A área do retângulo é: {area:F2}");
    }

    public static void CalcularPerimetro()
    {
        Console.WriteLine("Digite a largura: ");
        int largura = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura: ");
        int altura = int.Parse(Console.ReadLine());

        double perimetro = 2 * (largura + altura);

        Console.WriteLine($"O perímetro do retângulo é: {perimetro:F2}");
    }

    public static void CalcularDiagonal()
    {
        Console.WriteLine("Digite a largura: ");
        int largura = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura: ");
        int altura = int.Parse(Console.ReadLine());

        double diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

        Console.WriteLine($"A diagonal do retângulo é: {diagonal:F2}");
    }
}