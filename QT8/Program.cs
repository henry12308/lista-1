/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
• Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser 
distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
• Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade 
atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.

@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 03/09/2024
---------------------------------------------------------------------*/


class Program
{
    static void Main()
    {        
        int forca, agilidade, destreza, vitalidade, soma; 

        Console.WriteLine("pontos de força? ");
        int.TryParse(Console.ReadLine(), out forca);

         Console.WriteLine("pontos de agilidade? ");
        int.TryParse(Console.ReadLine(), out agilidade);

         Console.WriteLine("pontos de destreza? ");
        int.TryParse(Console.ReadLine(), out destreza);

         Console.WriteLine("pontos de vitalidade? ");
        int.TryParse(Console.ReadLine(), out vitalidade);

        soma = (forca + agilidade + destreza + vitalidade);

        Console.WriteLine($"puntuação total é de:: {soma}");

        Console.ReadLine();

    }
}