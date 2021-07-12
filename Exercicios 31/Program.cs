using System;

namespace Exercicios31
{
    class Program
    {
        static void Main(string[] args)
        {   
            int Jogador1;
            int papel = 0;
            int pedra = 1;
            int tesoura = 2;

            Random numAleatorio = new Random();
            int Jogador2 = numAleatorio.Next(2);

            Console.WriteLine("BEM VINDO AO PEDRA, TESOURA E PAPEL!!!!!!!!!!!!");

            Console.Write("Por favor, escolha umas dessas opções: (0) papel, (1) pedra, (2) tesoura: ");
            Jogador1 = int.Parse(Console.ReadLine());

            if(Jogador1 == 0)
            {
                Console.WriteLine("Você escolheu: Papel! ");
            }
            else if (Jogador1 == 1)
            {
                Console.WriteLine("Você escolheu: Pedra!");
            }
            else if (Jogador1 == 2)
            {
                Console.WriteLine("Você escolheu: Tesoura!");
            }
            else
            {
                Console.WriteLine("Programa fechado!");
                Environment.Exit(0);
            }

             if(Jogador2 == 0)
            {
                Console.WriteLine("Computador escolheu: Papel! ");
            }
            else if (Jogador2 == 1)
            {
                Console.WriteLine("Computador escolheu: Pedra!");
            }
            else if (Jogador2 == 2)
            {
                Console.WriteLine("Computador escolheu: Tesoura!");
            }

            if(Jogador1 == Jogador2)
            {
                Console.WriteLine("Empate");
            }else
            {
                if (Jogador1 == papel && Jogador2 == pedra)
                {
                    Console.WriteLine("Jogador ganhou! ");
                }
                else if (Jogador1 == pedra && Jogador2 == papel)
                {
                    Console.WriteLine("Computador ganhou!" );
                }
                else if(Jogador1 == tesoura && Jogador2 == papel)
                {
                    Console.WriteLine("Jogador ganhou!");
                }
                else if (Jogador1 == papel && Jogador2 == tesoura)
                {
                    Console.WriteLine("Computador ganhou!");
                }
                else if(Jogador1 == pedra && Jogador2 == tesoura)
                {
                    Console.WriteLine("Jogador ganhou!");
                }
                else if (Jogador1 == tesoura && Jogador2 == pedra)
                {
                    Console.WriteLine("Computador ganhou!");
                }
            }

        }
    
    }
}
