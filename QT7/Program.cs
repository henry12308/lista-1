/*-------------------------------------------------------------------
Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma
batalha. Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha, o
jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual
do personagem.
• Comando:Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido
pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo, o número de cada
tipo de inimigo derrotado, e a constante de nível. O programa deve calcular o XP total
acumulado após a batalha e determinar o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 02/09/2024
---------------------------------------------------------------------*/

class Program
{
    static void Main()
    {        
        int inimigo1, inimigo2;
        Double soma, xpAcumulado, xpCon1, xpCon2;

        Console.WriteLine("qual foi o xp acumulado? ");
        double.TryParse(Console.ReadLine(), out xpAcumulado);

         Console.WriteLine("xp do inimigo? ");
        double.TryParse(Console.ReadLine(), out xpCon1);

         Console.WriteLine("inimigos derrotados 1? ");
        int.TryParse(Console.ReadLine(), out inimigo1);

         Console.WriteLine("xp inimigo 2 ? ");
        double.TryParse(Console.ReadLine(), out xpCon2);

         Console.WriteLine("inimigos derrotados 2? ");
        int.TryParse(Console.ReadLine(), out inimigo2);

        soma = (xpAcumulado + xpCon1 * inimigo1 + xpCon2 * inimigo2);

        Console.WriteLine($"Xp total: {soma}");

        Console.ReadLine();

    }
}