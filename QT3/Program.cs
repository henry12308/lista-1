/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.
@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;
using System.Linq.Expressions;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
    Double vida, dano, bonus, modoequipamentos, modohabilidade;

    Console.WriteLine("quanto è a sua vida inicial?");
    Double.TryParse(Console.ReadLine(), out vida);

    Console.WriteLine("dano recebido?");
    Double.TryParse(Console.ReadLine(), out dano);

    Console.WriteLine("quantos bonus por regeneração?");
    Double.TryParse(Console.ReadLine(), out bonus);

    Console.WriteLine("quantos modificadores de equipamentos");
    Double.TryParse(Console.ReadLine(), out modoequipamentos);

    Console.WriteLine("quantos modificadores de habilidade?");
    Double.TryParse(Console.ReadLine(), out modohabilidade);

    Double Soma = ((vida - dano * modoequipamentos) + + bonus * modohabilidade);
    Console.WriteLine($"vida restante; {Soma}");

    Console.ReadLine();
    }


}
