using System;

namespace Lista4Exerc3
{
    /* 
        Escreva um programa que contenha uma variável: horaAtual;
        Essa variável deverá conter a hora do dia e três mensagens deverão ser
        impressas na tela de acordo com a hora:
        “Bom dia”, “Boa tarde” ou “Boa noite” 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int horaAtual;
            Console.Write("Digite a hora atual (apenas horas inteiras): ");
            horaAtual = int.Parse(Console.ReadLine());
            if(horaAtual >= 5 && horaAtual <= 13)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horaAtual >= 13 && horaAtual <= 19)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if(horaAtual >= 19 && horaAtual <= 23)
            {
                Console.WriteLine("Boa noite!");
            }
            else if (horaAtual >= 00 && horaAtual < 5)
            {
                Console.WriteLine("Boa madrugada!");
            }
        }
    }
}
