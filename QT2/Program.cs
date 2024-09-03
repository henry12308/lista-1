/*-------------------------------------------------------------------
Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.
@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main(string[] args)
    {
    Double inimigos, bonus, pontos, mult1, mult2, Soma;

    Console.WriteLine("qual foi a quantidade de inimigos derrotados??");
    Double.TryParse(Console.ReadLine(), out inimigos);


    Console.WriteLine("quantidade de pontos por inimigo derrotado?");
    Double.TryParse(Console.ReadLine(), out pontos);


    Console.WriteLine("qual foi o bonus recebido?");
    Double.TryParse(Console.ReadLine(), out bonus);


    Console.WriteLine("mult1");
    Double.TryParse(Console.ReadLine(), out mult1);

    Console.WriteLine("mult2");
    Double.TryParse(Console.ReadLine(), out mult2);


    Soma = (inimigos * mult1 * mult2) + bonus;

    Console.WriteLine($"pontuacao final: {Soma}");
    Console.ReadLine();
    
    }


}
