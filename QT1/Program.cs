﻿/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
•  Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
 personagem antes de começar a aventura.
•  Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
 personagem e exiba esses dados no console.
@Lista: 01 - Lógica de Programação
@Autor: João Henry
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        int idade, nivel;
        string? nome, raca, classe;

        Console.WriteLine("nome do jogador? ");
        nome = Console.ReadLine();
    


        Console.WriteLine("qual é a idade do jogaodr? ");
        int.TryParse(Console.ReadLine(), out idade);


        Console.WriteLine("qual é a raca do jogador? ");
        raca = Console.ReadLine();


        Console.WriteLine("qual é a classe? ");
        classe = Console.ReadLine();

        Console.WriteLine("qual é o seu nivel?");
        int.TryParse(Console.ReadLine(), out nivel);


        Console.WriteLine("nome: {nome}");
        Console.WriteLine("idade:  {idade}");
        Console.WriteLine("raça: {raca}");
        Console.WriteLine("classe: {classe}");
        Console.WriteLine("nivel: {nivel}");

        Console.WriteLine("\n pressione enter para fechar");
        Console.ReadLine();
    }


}

 
