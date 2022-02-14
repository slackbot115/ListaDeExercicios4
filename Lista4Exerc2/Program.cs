using System;

namespace Lista4Exerc2
{
    /* 
        Desenhe um retângulo com asteriscos, onde as linhas forem pares escreva
        "A" e as linhas ímpares escreva "B"
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
                if(i % 2 == 0)
                {
                    for (int j = 1; j < largura; j++)
                    {
                        Console.Write("A");
                    }
                }
                else
                {
                    for (int j = 1; j < largura; j++)
                    {
                        Console.Write("B");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
