/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
• Contextualização:No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.
@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 27/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    static void Main()
    {
        int moedas1, moedas2, moedas3, moedas4, moedas5, soma;

        Console.WriteLine("quantas moedas foram coletadas na primeira");
        int.TryParse(Console.ReadLine(), out moedas1);

        Console.WriteLine("quantas moedas foram coletadas na segunda");
        int.TryParse(Console.ReadLine(), out moedas2);

        Console.WriteLine("quantas moedas foram coletadas na terceira");
        int.TryParse(Console.ReadLine(), out moedas3);

        Console.WriteLine("quantas moedas foram coletadas na quarta");
        int.TryParse(Console.ReadLine(), out moedas4);

        Console.WriteLine("quantas moedas foram coletadas na quinta");
        int.TryParse(Console.ReadLine(), out moedas5);

        soma = (moedas1 + moedas2 + moedas3 + moedas4 + moedas5);
        
        Console.WriteLine($"o total é:{soma}");
    }
}