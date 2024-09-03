/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 27/08/2024
---------------------------------------------------------------------*/

class Program
{
    static void Main()
    {        
        int moedas, taxa;
        Double bonusEventos, bonusHabilidades, soma;

        Console.WriteLine("quantas moedas de ouro? ");
        int.TryParse(Console.ReadLine(), out moedas);

        Console.WriteLine("qual vai ser o valor da taxa de conversão? ");
        int.TryParse(Console.ReadLine(), out taxa);

        Console.WriteLine("qual sera o valor do bonus evento? ");
        double.TryParse(Console.ReadLine(), out bonusEventos);

        Console.WriteLine("qual sera o valor do bonus de habilidade? ");
        double.TryParse(Console.ReadLine(), out bonusHabilidades);

        soma = ((moedas / taxa) + bonusEventos) + bonusHabilidades;
        Console.WriteLine("o numero de cristais obtidos vai ser de: " + Math.Floor(soma));
        Console.ReadLine();
        
    
    }
}