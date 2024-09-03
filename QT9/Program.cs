/*-------------------------------------------------------------------
Atividade 9: Comparação de Poder de Ataque
• Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em 
sua força, arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos 
e pelo tipo da arma.
• Crie um programa que receba o valor da força do personagem, o poder da arma, o bônus de 
Comando: habilidades, um modificador de crítico, e um modificador para o tipo da arma. O 
programa deve calcular o total de ataque do personagem

@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 03/09/2024
---------------------------------------------------------------------*/

class Program
{
    static void Main()
    {        
        int forca, poder; 
        double bonus, modiCritico, modiArma, total;

        Console.WriteLine("qual o valor da força? ");
        int.TryParse(Console.ReadLine(), out forca);

         Console.WriteLine("qual o poder da arma? ");
        int.TryParse(Console.ReadLine(), out poder);

         Console.WriteLine("qual o bonus da habilidade? ");
        double.TryParse(Console.ReadLine(), out bonus);

         Console.WriteLine("qual é o modificaodr de critico? ");
        double.TryParse(Console.ReadLine(), out modiCritico);

        Console.WriteLine("qual é o modificador de arma? ");
        double.TryParse(Console.ReadLine(), out modiArma );

        total = ((forca + poder * modiArma) * bonus) * modiCritico;

        Console.WriteLine($"seu poder total: " + Math.Floor(total));

        Console.ReadLine();
    }
}