using System;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o cálculo:");
            Console.WriteLine("1 - Área do Retângulo");
            Console.WriteLine("2 - Perímetro do Retângulo");
            Console.WriteLine("3 - Diagonal do Retângulo");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CalcularArea();
                    break;
                case 2:
                    CalcularPerimetro();
                    break;
                case 3:
                    CalcularDiagonal();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        static void CalcularArea()
        {
            Console.WriteLine("Digite a largura: ");
            int largura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            int altura = int.Parse(Console.ReadLine());

            double area = largura * altura;

            Console.WriteLine($"A área do retângulo é: {area:F2}");
        }

        static void CalcularPerimetro()
        {
            Console.WriteLine("Digite a largura: ");
            int largura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            int altura = int.Parse(Console.ReadLine());

            double perimetro = 2 * (largura + altura);

            Console.WriteLine($"O perímetro do retângulo é: {perimetro:F2}");
        }

        static void CalcularDiagonal()
        {
            Console.WriteLine("Digite a largura: ");
            int largura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            int altura = int.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

            Console.WriteLine($"A diagonal do retângulo é: {diagonal:F2}");
        }
    }
}
