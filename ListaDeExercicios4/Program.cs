using System;

namespace ListaDeExercicios4
{
    /* 
        Desenhe um retângulo com asteriscos, considere que o primeiro input é a
        largura do retângulo, e o segundo input é a altura.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int largura, altura;

            Console.Write("Digite a largura do retangulo: ");
            largura = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura do retangulo: ");
            altura = int.Parse(Console.ReadLine());
            for (int i = 0; i < altura; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < largura; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
