using System;

namespace Lista4Exerc4
{
    /* 
        Desenvolver um algoritmo que leia 5 valores inteiros e calcule e escreva a
        média aritmética dos valores lidos, a quantidade de valores positivos e a
        quantidade de valores negativos.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int qtValNegativo = 0, qtValPositivo = 0, somaValores = 0;
            double media;
            int[] valores = new int[5];

            Console.WriteLine("Inserindo valores...");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o valor: ");
                valores[i] = int.Parse(Console.ReadLine());
                somaValores += valores[i];
                if(valores[i] < 0)
                {
                    qtValNegativo++;
                }
                else
                {
                    qtValPositivo++;
                }
            }
            media = somaValores / valores.Length;
            Console.WriteLine("Média aritmética: " + media);
            Console.WriteLine("Quantidade de números positivos: " + qtValPositivo);
            Console.WriteLine("Quantidade de números negativos: " + qtValNegativo);
        }
    }
}
