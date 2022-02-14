using System;

namespace Lista4Exerc5
{
    /* 
        Criar um jogo simplificado onde dois jogadores podem jogar dados;
        Regras:
        O jogo deverá solicitar o nome dos dois jogadores;
        O jogo terá 3 rodadas;
        O jogador que tirar o maior número nos dados nessas 3 rodadas vence;
        Em caso de empate (onde os dois tiram o mesmo número), nenhum
        jogador pontuará;
        Os números permitidos vão de 0 a 6.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            string jogador1, jogador2;
            const int rodadas = 3;
            bool acabou = false;
            Random randomNum = new Random();

            while (true)
            {
                int ptsJogador1 = 0, ptsJogador2 = 0;
                Console.Write("Digite o nome do jogador 1: ");
                jogador1 = Console.ReadLine();
                Console.Write("Digite o nome do jogador 2: ");
                jogador2 = Console.ReadLine();

                for (int i = 1; i <= rodadas; i++)
                {
                    // Primeira rodada
                    if (i == 1)
                    {
                        Console.WriteLine("\n1ª rodada:");
                        int playJogador1 = randomNum.Next(1, 7);
                        int playJogador2 = randomNum.Next(1, 7);
                        Console.WriteLine("{0}: {1}", jogador1, playJogador1);
                        Console.WriteLine("{0}: {1}", jogador2, playJogador2);
                        if (playJogador1 > playJogador2)
                        {
                            Console.WriteLine("O jogador {0} jogou {1} e venceu a 1ª rodada", jogador1, playJogador1);
                            ptsJogador1++;
                        }
                        // Desempate primeira rodada
                        else if (playJogador1 == playJogador2)
                        {
                            while (true)
                            {
                                int desempateJogador1 = randomNum.Next(1, 7);
                                int desempateJogador2 = randomNum.Next(1, 7);
                                Console.WriteLine("\nCaso de empate 1ª rodada");
                                Console.WriteLine("{0}: {1}", jogador1, desempateJogador1);
                                Console.WriteLine("{0}: {1}", jogador2, desempateJogador2);
                                if (desempateJogador1 > desempateJogador2)
                                {
                                    Console.WriteLine("O jogador {0} jogou {1} e venceu a 1ª rodada", jogador1, desempateJogador1);
                                    ptsJogador1++;
                                    break;
                                }
                                else if(desempateJogador2 > desempateJogador1)
                                {
                                    Console.WriteLine("O jogador {0} jogou {1} e venceu a 1ª rodada", jogador2, desempateJogador2);
                                    ptsJogador2++;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("O jogador {0} jogou {1} e venceu a 1ª rodada", jogador2, playJogador2);
                            ptsJogador2++;
                        }
                        Console.ReadKey();
                    }
                    // Segunda rodada
                    else if (i == 2)
                    {
                        Console.WriteLine("\n2ª rodada:");
                        int playJogador1 = randomNum.Next(1, 7);
                        int playJogador2 = randomNum.Next(1, 7);
                        Console.WriteLine("{0}: {1}", jogador1, playJogador1);
                        Console.WriteLine("{0}: {1}", jogador2, playJogador2);
                        if (playJogador1 > playJogador2)
                        {
                            Console.WriteLine("O jogador {0} jogou {1} e venceu a 2ª rodada", jogador1, playJogador1);
                            ptsJogador1++;
                            Console.ReadKey();
                            if (ptsJogador1 > ptsJogador2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nO jogador {0} venceu o jogo!", jogador1);
                                Console.ResetColor();
                                break;
                            }
                        }
                        // Desempate segunda rodada
                        else if (playJogador1 == playJogador2)
                        {
                            while (true)
                            {
                                int desempateJogador1 = randomNum.Next(1, 7);
                                int desempateJogador2 = randomNum.Next(1, 7);
                                Console.WriteLine("\nCaso de empate 2ª rodada");
                                Console.WriteLine("{0}: {1}", jogador1, desempateJogador1);
                                Console.WriteLine("{0}: {1}", jogador2, desempateJogador2);
                                if (desempateJogador1 > desempateJogador2)
                                {
                                    Console.WriteLine("O jogador {0} jogou {1} e venceu a 2ª rodada", jogador1, desempateJogador1);
                                    ptsJogador1++;
                                    if (ptsJogador1 > ptsJogador2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nO jogador {0} venceu o jogo!", jogador1);
                                        Console.ResetColor();
                                        acabou = true; // Apenas para não entrar no if da terceira rodada caso já haja um vencedor
                                        break;
                                    }
                                }
                                else if (desempateJogador2 > desempateJogador1)
                                {
                                    Console.WriteLine("O jogador {0} jogou {1} e venceu a 2ª rodada", jogador2, desempateJogador2);
                                    ptsJogador2++;
                                    if (ptsJogador2 > ptsJogador1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nO jogador {0} venceu o jogo!", jogador2);
                                        Console.ResetColor();
                                        acabou = true; // Apenas para não entrar no if da terceira rodada caso já haja um vencedor
                                        break;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("O jogador {0} jogou {1} e venceu a 2ª rodada", jogador2, playJogador2);
                            ptsJogador2++;
                            Console.ReadKey();
                            if (ptsJogador2 > ptsJogador1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nO jogador {0} venceu o jogo!", jogador2);
                                Console.ResetColor();
                                break;
                            }
                        }
                    }
                    // Terceira rodada
                    else if (i == 3 && acabou == false)
                    {
                        Console.WriteLine("\n3ª rodada:");
                        int playJogador1 = randomNum.Next(1, 7);
                        int playJogador2 = randomNum.Next(1, 7);
                        Console.WriteLine("{0}: {1}", jogador1, playJogador1);
                        Console.WriteLine("{0}: {1}", jogador2, playJogador2);
                        if (playJogador1 > playJogador2)
                        {
                            Console.WriteLine("O jogador {0} jogou {1} e venceu a 3ª rodada", jogador1, playJogador1);
                            ptsJogador1++;
                            Console.ReadKey();
                            if (ptsJogador1 > ptsJogador2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nO jogador {0} venceu o jogo!", jogador1);
                                Console.ResetColor();
                                break;
                            }
                        }
                        // Desempate terceira rodada
                        else if (playJogador1 == playJogador2)
                        {
                            while (true)
                            {
                                int desempateJogador1 = randomNum.Next(1, 7);
                                int desempateJogador2 = randomNum.Next(1, 7);
                                Console.WriteLine("\nCaso de empate 3ª rodada");
                                Console.WriteLine("{0}: {1}", jogador1, desempateJogador1);
                                Console.WriteLine("{0}: {1}", jogador2, desempateJogador2);
                                if (desempateJogador1 > desempateJogador2)
                                {
                                    Console.WriteLine("O jogador {0} jogou {1} e venceu a 3ª rodada", jogador1, desempateJogador1);
                                    ptsJogador1++;
                                    if (ptsJogador1 > ptsJogador2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nO jogador {0} venceu o jogo!", jogador2);
                                        Console.ResetColor();
                                        break;
                                    }
                                }
                                else if (desempateJogador2 > desempateJogador1)
                                {
                                    Console.WriteLine("O jogador {0} jogou {1} e venceu a 3ª rodada", jogador2, desempateJogador2);
                                    ptsJogador2++;
                                    if (ptsJogador2 > ptsJogador1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nO jogador {0} venceu o jogo!", jogador2);
                                        Console.ResetColor();
                                        break;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("O jogador {0} jogou {1} e venceu a 3ª rodada", jogador2, playJogador2);
                            ptsJogador2++;
                            Console.ReadKey();
                            if (ptsJogador2 > ptsJogador1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nO jogador {0} venceu o jogo!", jogador2);
                                Console.ResetColor();
                                break;
                            }
                        }
                    }
                }
                // Menu
                Console.WriteLine("\nGostaria de jogar novamente?\n1 - Sim\n2 - Não");
                int op = int.Parse(Console.ReadLine());
                if(op == 1)
                {
                    Console.Clear();
                    continue;
                }
                else if (op == 2)
                {
                    Console.WriteLine("Fechando o programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção invalida, reiniciando o jogo...\n\n");
                }
            }
        }
    }
}
