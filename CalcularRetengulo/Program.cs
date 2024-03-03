using System;

namespace CalcularRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o calculo:");
            Console.WriteLine("1 - Área do Retangulo");
            Console.WriteLine("2 - Perimetro do Retangulo");
            Console.WriteLine("3 - Diagonal do Retangulo");

            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    CalculadoraRetangulo.CalcularArea();
                    break;
                case 2:
                    CalculadoraRetangulo.CalcularPerimetro();
                    break;
                case 3:
                    CalculadoraRetangulo.CalcularDiagonal();
                    break;
            }
        }

    }
}