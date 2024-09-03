/*--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
questão2:pontuação final
*
contextualização:no final de uma missão em um jogo, a pontuação do jogador é calculada com base no inimigos derrotados e pontos adicionais.
*comando:desenvolva um programa que receba o numero de inimigos derrotados,
a pontuação por inimigo, bônus por missão, e dois multiplicadores
 (um para tipo de inimigo e outro para dificuldade),e então calcule e exiba a pontuação final
 @lista: 01 - lógica de programação
@autor: Alice rocha
@data: 02/09/2024
----------------------------------------------------------------------------------*/
using System;

class Program

    {
        static void Main()
        {
            int inimigos, pontosinimigo, missão; 
            double multDif, multBonus, pontosFinais;
            
            Console.WriteLine("escreva quantos inimigos foram derrotados");
            int.TryParse(Console.ReadLine(), out inimigos);
            Console.WriteLine("quantos pontos por inimigo?");
            int.TryParse(Console.ReadLine(),out pontosinimigo);
            System.Console.WriteLine("quanto foi o bonus de missão?");
            int.TryParse(Console.ReadLine(), out missão);

            System.Console.WriteLine("qual foi o multiplicador de bonus?");
            double.TryParse(Console.ReadLine(),out multBonus);
            System.Console.WriteLine("qual foi o multiplacador de dficildade?");
            double.TryParse(Console.ReadLine () , out multDif);

            pontosFinais = inimigos * multBonus *  multDif + missão;

            System.Console.WriteLine("sua pontuação final é:" + pontosFinais);
            
            System.Console.WriteLine("\n Aperte Enter para fechar");
            Console.ReadLine();
        }

    }

