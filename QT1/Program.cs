/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as 
  informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, 
  classe, e raça do personagem e exiba esses dados no console.
@Lista: 01 - Lógica de Programação
@Autor: Alice rocha 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? nome, classe, raca;
        int idade, nivel;

        System.Console.WriteLine("escreva o nome do seu perrsonagem");
        nome =  Console.ReadLine();
        System.Console.WriteLine("escreva a idade do seu personagem");
        int.TryParse(Console.ReadLine(), out idade);
        System.Console.WriteLine("escreva seu nivel");
        int.TryParse(Console.ReadLine(),out nivel);
        System.Console.WriteLine("escreva sua classe");
        classe= Console.ReadLine();
        System.Console.WriteLine("escreva sua raca");
        raca = Console.ReadLine();
        Console.Clear(); 


        System.Console.WriteLine("dados do seu personagem são: \n" +
        "nome: " + nome + "\n" +
        "idade:" + idade + "\n" +
        "nivel:" + nivel + "\n" +
        "classe:"+ classe + "\n" +
        "raca:"  + raca + "\n");

        System.Console.WriteLine("\n aperte ENTER para fechar.");
       
        Console.ReadLine();

    
    }
}