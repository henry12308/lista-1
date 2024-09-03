/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização:Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: João Henry Brito Cavalcante
@Data: 27/08/2024
---------------------------------------------------------------------*/

using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {        
        int velocidade , tempo;
        Double mult1, mult2, soma;

        Console.WriteLine("qual vai ser a velocidade? ");
        int.TryParse(Console.ReadLine(), out velocidade);

         Console.WriteLine("qual foi o tempo? ");
        int.TryParse(Console.ReadLine(), out tempo);

         Console.WriteLine("qual vai ser o mutiplicador climatico? ");
        double.TryParse(Console.ReadLine(), out mult1);

         Console.WriteLine("qual vai ser o mutiplicaor do estado do veiculo? ");
        double.TryParse(Console.ReadLine(), out mult2);

        soma = (velocidade * tempo * mult1 * mult2);
        Console.WriteLine($"A distancia pecorrida vai ser de:{soma}");
    }
}

