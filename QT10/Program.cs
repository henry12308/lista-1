/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a 
cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida 
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.

@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 03/09/2024
---------------------------------------------------------------------*/

class Program
{
    static void Main()
    {        
        int pontosIniciais, aumento, nivel, soma; 

        Console.WriteLine("quantidade de pontos iniciais? ");
        int.TryParse(Console.ReadLine(), out pontosIniciais);

         Console.WriteLine("quantos aumentos por niveis? ");
        int.TryParse(Console.ReadLine(), out aumento);

         Console.WriteLine("quantoa niveis alcançados? ");
        int.TryParse(Console.ReadLine(), out nivel);

        soma = ((aumento * nivel) + pontosIniciais);

        Console.WriteLine($"os pontos finais são: {soma}");

        Console.ReadLine();
    }
}